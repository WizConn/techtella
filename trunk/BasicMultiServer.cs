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
        public ArrayList knownPeers, foundPeers, activePings, activeQueries, chatMessages;
        public int portnum;
        public static int filePort;

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

        public void ForwardPong(Packet pong)
        {
            foreach (object hostname in knownPeers)
            {
                Client.Pong(ParseHostname((string)hostname), 12345, pong.descriptor, pong.msg);
            }
        }

        public void ForwardQHit(Packet qHit)
        {
            foreach (object hostname in knownPeers)
            {
                Client.QueryHit(ParseHostname((string)hostname), 12345, qHit);
            }
        }

        public void SetInactive(int descriptor)
        {
            activePings.Remove(descriptor);
        }
        
        public void SetQInactive(int descriptor)
        {
            activeQueries.Remove(descriptor);
        }

        public BasicMultiServer()
        {
            knownPeers = new ArrayList();
            activePings = new ArrayList();
            activeQueries = new ArrayList();
            chatMessages = new ArrayList();
            filePort = 23456;
        }

        public bool IsActive(Packet toCheck)
        {
            foreach (object active in activePings)
            {
                if (toCheck.descriptor == Int32.Parse(active.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsQActive(Packet toCheck)
        {
            foreach (object active in activeQueries)
            {
                if (toCheck.descriptor == Int32.Parse(active.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddActivePing(int descriptor)
        {
            activePings.Add(descriptor);
        }

        public void AddActiveQuery(int descriptor)
        {
            activeQueries.Add(descriptor);
        }

        public void PongBack(Packet p, string target)
        {
            Client.Pong(target.Split(':')[0], 12345, p.descriptor, p.msg);
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
            hostname += "_" + portnum.ToString();
            knownPeers.Add(hostname);
        }

        public void AddFoundPeer(string hostname, int portnum)
        {
            hostname += "_" + portnum.ToString();
            foundPeers.Add(hostname);
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
            chatMessages.Add("Message from client at " + from + ":  " + message);
        }
    }
}