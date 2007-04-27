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
        public static int statPing = 0;
        public static int statPong = 0;
        public static int statPush = 0;
        public static int TTL = 10;
        public static int MyQuery = 0; //PUT IN TO GET RID OFF ERROR - WHAT IS THIS?

        public Client()
        {
            ManagementClass oMClass = new ManagementClass("Win32_NetworkAdapterConfiguration");

            ManagementObjectCollection colMObj = oMClass.GetInstances();

            descriptorHash = colMObj.GetHashCode();

            Console.WriteLine(colMObj.GetHashCode());
        }

        public static int Ping(string host, int portnum)
        {
            try
            {
                statPing++;
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
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("PING needs to be handled in a more professional manner\n" + e);
                return 0;
            }
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static int Ping(string host, int portnum, int descriptor)
        {
            try
            {
                statPing++;
                pingCount++;
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
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("PING needs to be handled in a more professional manner\n" + e);
                return 0;
            }
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static void RePing(string host, int portnum, int hops, int timeToLive, int descriptor)
        {
            try
            {
                statPing++;
                string msg = descriptor.ToString() + "?" + ((byte)0).ToString() + "?" + timeToLive.ToString() + "?" + hops.ToString() + "?" + "0" + "??";

                TcpClient client = new TcpClient(host.Split(':')[0], portnum);
                Console.WriteLine("Client.RePing called on " + host + ":" + portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("REPING needs to be handled in a more professional manner\n" + e);
            }
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static void Pong(string host, int portnum, int descriptor, string mesg)
        {
            try
            {
                statPong++;
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
            }
            catch (Exception e)
            {
                Console.WriteLine("PONG needs to be handled in a more professional manner\n" + e);
            }
            //delete this line
           // Console.WriteLine(reader.ReadLine());
        }

        public static void SendMsg(string host, int portnum, string msg)
        {
            TcpClient client = new TcpClient(host.Split(':')[0], portnum);
            try
            {
                Console.WriteLine("Client.SendMsg called on " + host + ":" + portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine("##" + msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("SENDMSG needs to be handled in a more professional manner\n" + e);
            }
           // Console.WriteLine(reader.ReadLine());
        }

        public static void Query(string host, int portnum, int TTL, string criteria, bool myQuery)
        {
            try
            {
                Console.WriteLine("Client.Query called on " + host + ":" + portnum);
                pingCount++;
                int descriptor = descriptorHash * 10 + pingCount;
                byte type = new byte();
                type = 80;
                string msg = descriptor.ToString() + "?" + type.ToString() + "?" + TTL.ToString() + "?0?" + criteria.Length.ToString() + "?" + criteria + "?";

                if (myQuery)
                {
                    MyQuery = descriptor;
                }

                TcpClient client = new TcpClient(host.Split(':')[0].Split('_')[0], portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            catch(Exception e)
            {
                Console.WriteLine("QUERY needs to be handled in a more professional manner\n" + e);
            }
        }

        public static void Query(string host, int portnum, int TTL, string criteria, bool myQuery, int descript)
        {
            try
            {
                Console.WriteLine("Client.Query called on " + host + ":" + portnum);
                pingCount++;
                int descriptor = descript;
                byte type = new byte();
                type = 80;
                string msg = descriptor.ToString() + "?" + type.ToString() + "?" + TTL.ToString() + "?0?" + criteria.Length.ToString() + "?" + criteria + "?";

                if (myQuery)
                {
                    MyQuery = descriptor;
                }

                TcpClient client = new TcpClient(host.Split(':')[0].Split('_')[0], portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("QUERY needs to be handled in a more professional manner\n" + e);
            }
        }

        public static void ReQuery(string host, int portnum, int hops, int timeToLive, int descriptor, string mesg)
        {
            try
            {
                string msg = descriptor.ToString() + "?" + ((byte)80).ToString() + "?" + timeToLive.ToString() + "?" + hops.ToString() + "?" + mesg.Length.ToString() + "?" + mesg + "?";

                TcpClient client = new TcpClient(host.Split(':')[0], portnum);
                Console.WriteLine("Client.ReQuery called on " + host + ":" + portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("REQUERY needs to be handled in a more professional manner\n" + e);
            }
            //delete this line
            //Console.WriteLine(reader.ReadLine());
        }

        public static void QueryHit(string host, int portnum, BasicMultiServer.Packet qhit)
        {
            Console.WriteLine("Client.QueryHit called on " + host+ ":" + portnum);
            //a split('?')[5] will yeild the query hit packet
            //a split('&')[0] = port
            //[1] = address
            //[2] = index (always 0)
            //[3] = file size in bytes
            //[4] = length of file name
            //[5] = name of the file
            //[6] = access code for the file's download
            try
            {
                Console.WriteLine("Client.Query called on " + host + ":" + portnum);
                pingCount++;
                int descriptor = descriptorHash * 10 + pingCount;

                string msg = qhit.descriptor.ToString() + "?" + qhit.type.ToString() + "?" + qhit.ttl.ToString() + "?0?" + qhit.msg.Length.ToString() + "?" + qhit.msg + "?";

                TcpClient client = new TcpClient(host.Split(':')[0].Split('_')[0], portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("QUERY HIT needs to be handled in a more professional manner\n" + e);
            }
        }

        public static void Push(string host, int portnum, string filename, int downcode)
        {
            Console.WriteLine("Client.Push called on " + host + ":" + portnum);
            try
            {
                pingCount++;
                statPush++;
                int descriptor = descriptorHash * 10 + pingCount;
                byte type = (byte)40;
                //descriptor, type, zero, zero, downcode, filename
                string msg = descriptor.ToString() + "?" + type.ToString() + "?0?0?" + downcode+ "?" + filename + "?";

                TcpClient client = new TcpClient(host.Split(':')[0].Split('_')[0], portnum);

                NetworkStream netStream = client.GetStream();
                StreamReader reader = new StreamReader(netStream);
                StreamWriter writer = new StreamWriter(netStream);

                writer.WriteLine(msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                Console.WriteLine("PUSH needs to be handled in a more professional manner\n" + e);
            }
        }

    }
}
