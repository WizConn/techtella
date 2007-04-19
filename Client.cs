using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Management;

namespace Techtella
{
    class Client
    {
        public static int descriptorHash;
        public static int pingCount = 0;
        public static int pongCount = 0;
        public static int TTL = 10;
        public static int MyQuery = 0; //PUT IN TO GET RID OFF ERROR - WHAT IS THIS?

        public Client()
        {
            ManagementClass oMClass = new ManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementObjectCollection colMObj = oMClass.GetInstances();

            descriptorHash = colMObj.GetHashCode();

            Console.WriteLine(colMObj.GetHashCode());
        }

        public static void Ping(string host, int portnum)
        {
            pingCount++;
            int descriptor = descriptorHash * 10 + pingCount;
            byte type = new byte();
            type = 0;

            string msg = descriptor.ToString() + "?" + type.ToString() + "?" + TTL.ToString() + "?0?0??";

            TcpClient client = new TcpClient(host.Split(':')[0], portnum);
            Console.WriteLine("Client.Ping called on " + host + ":" + portnum);

            NetworkStream netStream = client.GetStream();
            StreamReader reader = new StreamReader(netStream);
            StreamWriter writer = new StreamWriter(netStream);

            writer.WriteLine(msg);
            writer.Flush();
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static void RePing(string host, int portnum, int hops, int timeToLive, int descriptor)
        {
            string msg = descriptor.ToString() + "?" + ((byte)0).ToString() + "?" + timeToLive.ToString() + "?" + hops.ToString() + "?" + "0" + "??";

            TcpClient client = new TcpClient(host.Split(':')[0], portnum);
            Console.WriteLine("Client.RePing called on " + host + ":" + portnum);

            NetworkStream netStream = client.GetStream();
            StreamReader reader = new StreamReader(netStream);
            StreamWriter writer = new StreamWriter(netStream);

            writer.WriteLine(msg);
            writer.Flush();
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static void Pong(string host, int portnum, int descriptor, string mesg)
        {
            pongCount++;
            string msg = descriptor.ToString() + "?" + ((byte)1).ToString() + "?" + TTL.ToString() + "?" + "0?" + mesg.Length.ToString() + "?" + mesg + "?";
            if (host.Split(':')[0] == "127.0.0.1")
            {
                Console.WriteLine("cannot pong loopback, ignoring pong request");
            }
            else
            {
                TcpClient client = new TcpClient(host.Split(':')[0], portnum);
                Console.WriteLine("Client.Pong called on " + host + ":" + portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            //delete this line
           // Console.WriteLine(reader.ReadLine());
        }

        public static void SendMsg(string host, int portnum, string msg)
        {
            TcpClient client = new TcpClient(host.Split(':')[0], portnum);
            Console.WriteLine("Client.SendMsg called on " + host + ":" + portnum);

            NetworkStream netStream = client.GetStream();
            StreamReader reader = new StreamReader(netStream);
            StreamWriter writer = new StreamWriter(netStream);

            writer.WriteLine("##" + msg);
            writer.Flush();

           // Console.WriteLine(reader.ReadLine());
        }

        public static void Query(string host, int portnum, int TTL, string criteria)
        {
            pingCount++;
            int descriptor = descriptorHash * 10 + pingCount;
            byte type = new byte();
            type = 80;

            string msg = descriptor.ToString() + "?" + type.ToString() + "?" + TTL.ToString() + "?0?" + criteria.Length.ToString() + "?" + criteria + "?";

            TcpClient client = new TcpClient(host.Split(':')[0], portnum);
            Console.WriteLine("Client.Query called on " + host + ":" + portnum);

            NetworkStream netStream = client.GetStream();
            StreamReader reader = new StreamReader(netStream);
            StreamWriter writer = new StreamWriter(netStream);

            writer.WriteLine(msg);
            writer.Flush();
        }

        public static void ReQuery(string host, int portnum, int hops, int timeToLive, int descriptor, string mesg)
        {
            string msg = descriptor.ToString() + "?" + ((byte)80).ToString() + "?" + timeToLive.ToString() + "?" + hops.ToString() + "?" + mesg.Length.ToString() +"?" + mesg + "?";

            TcpClient client = new TcpClient(host.Split(':')[0], portnum);
            Console.WriteLine("Client.ReQuery called on " + host + ":" + portnum);

            NetworkStream netStream = client.GetStream();
            StreamReader reader = new StreamReader(netStream);
            StreamWriter writer = new StreamWriter(netStream);

            writer.WriteLine(msg);
            writer.Flush();
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static void QueryHit(string hostname, int port, BasicMultiServer.Packet qhit)
        {
            Console.WriteLine("Client.QueryHit called on " + hostname + ":" + port);
        }

    }
}
