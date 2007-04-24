using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Techtella
{
    public class BasicMultiServer
    {
        public static string immediateIP;
        public ArrayList knownPeers, foundPeers, activePings, activeQueries, chatMessages, queryHits;
        public int portnum;
        public static int filePort;
        public DateTime starttime, now;

        public struct Packet
        {
            public int descriptor;
            public byte type;
            public int ttl;
            public int hops;
            public int length;
            public string msg;
            public string from;
        }

        public void CreatePing(string host, int port)
        {
            int descriptor = Client.descriptorHash * 100 + Client.pingCount + 1;
            AddActivePing(descriptor, "127.0.0.1");
            Client.Ping(host, portnum, descriptor);
        }

        public void ForwardPing(Packet ping, string ignore)
        {
            foreach (object hostname in knownPeers)
            {
                if (ParseHostname((string)hostname) != ignore)
                {
                    Client.RePing(ParseHostname((string)hostname), 12345, ping.hops, ping.ttl, ping.descriptor);
                }
            }
        }

        public void ForwardQuery(Packet query, string ignore)
        {
            foreach (object hostname in knownPeers)
            {
                if (ParseHostname((string)hostname) != ignore)
                {
                    Client.ReQuery(ParseHostname((string)hostname), 12345, query.hops, query.ttl, query.descriptor, query.msg);
                }
            }
        }

        public void ForwardPong(Packet pong, string ignore)
        {
            foreach (object hostname in activePings)
            {
                if (((string)hostname).Split(':')[0] != ignore.Split(':')[0])
                {
                    Client.Pong(ParseHostname((string)hostname).Split(':')[0], 12345, pong.descriptor, pong.msg);
                }
            }
        }

        public void ForwardQHit(Packet qHit, string ignore)
        {
            foreach (object hostname in knownPeers)
            {
                if (ParseHostname(hostname.ToString()).Split(':')[0] != ignore.Split(':')[0])
                {
                    Client.QueryHit(ParseHostname((string)hostname), 12345, qHit);
                }
            }
        }

        public void SetInactive(object remove)
        {
            activePings.Remove(remove);
        }
        
        public void SetQInactive(object remove)
        {
            activeQueries.Remove(remove);
        }

        public BasicMultiServer()
        {
            knownPeers = new ArrayList();
            foundPeers = new ArrayList();
            activePings = new ArrayList();
            activeQueries = new ArrayList();
            chatMessages = new ArrayList();
            queryHits = new ArrayList();
            starttime = DateTime.Now;
            filePort = 23456;
        }

        public bool IsActive(Packet toCheck)
        {
            TimeSpan age;
            System.Console.WriteLine("Checking " + activePings.Count + " active pings");
            ArrayList currentPings = (ArrayList)activePings.Clone();
            foreach (object active in currentPings)
            {
                Console.WriteLine(toCheck.descriptor + " ?= " + Int32.Parse(active.ToString().Split('_')[1]));
                age = DateTime.Now - DateTime.Parse(active.ToString().Split('_')[2]);
                if (age.Seconds >= 10)
                {
                    SetInactive(active);
                    Console.WriteLine("Set a ping inactive, descriptor:  " + Int32.Parse(active.ToString().Split('_')[1]));
                }
                else if (toCheck.descriptor == Int32.Parse(active.ToString().Split('_')[1]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsQActive(Packet toCheck)
        {
            TimeSpan age;
            Console.WriteLine("Checking " + activeQueries.Count + " active queries");
            ArrayList currentQueries = (ArrayList)activeQueries.Clone();
            foreach (object active in currentQueries)
            {
                age = DateTime.Now - DateTime.Parse(active.ToString().Split('_')[1]);
                if (age.Seconds >= 10)
                {
                    SetQInactive(active);
                    Console.WriteLine("Set a query inactive, descriptor:  " + Int32.Parse(active.ToString().Split('_')[0]));
                }
                else if (toCheck.descriptor == Int32.Parse(active.ToString().Split('_')[0]))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddActivePing(int descriptor, string from)
        {
            activePings.Add(from + "_" + descriptor + "_" + DateTime.Now);
        }

        public void AddActiveQuery(int descriptor)
        {
            activeQueries.Add(descriptor + "_" + DateTime.Now);
        }

        public void PongBack(Packet p, string target)
        {
            Client.Pong(target, 12345, p.descriptor, p.msg);
        }

        public void QHitBack(Packet p, string ignore)
        {
            foreach (object hostname in knownPeers)
            {
                if (ParseHostname((string)hostname) != ignore)
                {
                    Client.QueryHit(ParseHostname((string)hostname), 12345, p);
                }
            }
        }

        public string ParseHostname(string hostie)
        {
            return hostie.Split('_')[0];
        }

        public void AddKnownPeer(string hostname, int portnum)
        {
            bool alreadyknown = false;
            foreach (object host in knownPeers)
            {
                if (host.ToString().Split('_')[0] == hostname)
                {
                    alreadyknown = true;
                }
            }
            if (!alreadyknown)
            {
                hostname += "_" + portnum.ToString();
                knownPeers.Add(hostname);
            }
        }

        public void AddFoundPeer(string hostname, int portnum)
        {
            Console.WriteLine("AddFoundPeer called with args: " + hostname + " " + portnum);
            bool alreadyknown = false;
            foreach (object host in foundPeers)
            {
                if (host.ToString().Split('_')[0].Split(':')[0] == hostname.Split(':')[0].Split('_')[0])
                {
                    alreadyknown = true;
                    Console.WriteLine("Peer already known");
                }
                Console.WriteLine(host.ToString());
            }
            if (!alreadyknown)
            {
                hostname += "_" + portnum.ToString();
                foundPeers.Add(hostname);
                Console.WriteLine("ADDED: " + hostname);
            }
        }

        private void Run()
        {
            Console.WriteLine("Starting Server");
            string myHost = System.Net.Dns.GetHostName();
            string myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[0].ToString();
            IPAddress ipaddr = IPAddress.Parse(myIP);
            Console.WriteLine("IPADDR: " + myIP);
            Console.WriteLine("PORT:  12345");
            portnum = 12345;
            TcpListener listener = new TcpListener(ipaddr, portnum);
            listener.Start();

            while (true)
            {
                Socket sock = listener.AcceptSocket();
                Console.WriteLine("Got connection");
                Console.WriteLine(sock.RemoteEndPoint.ToString());
                immediateIP = sock.RemoteEndPoint.ToString();
                ClientHandler ch = new ClientHandler(sock, this);
                ch.StartRead();
            }
        }

        public void RunThreaded()
        {
            Thread threadedRun = new Thread(Run);
            threadedRun.Start();
        }

        public void AddChatMessage(string message, string from)
        {
            chatMessages.Add("Message from client at " + from.Split(':')[0] + ":  " + message.Substring(2, message.Length-3));
        }

        public void AddQueryHit(string qhit)
        {
            queryHits.Add(qhit);
        }

        public void CreateQuery(string criteria)
        {
            int descriptor = Client.descriptorHash*100 + Client.pingCount + 1;
            AddActiveQuery(descriptor);
            foreach (object host in knownPeers)
            {
                Client.Query(host.ToString().Split(':')[0], 12345, 10, criteria);
            }
        }
    }
}