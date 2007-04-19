using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Management;
using System.Threading;
using System.Collections;

namespace Techtella
{
    [TestFixture]
    class ClientHandlerTest
    {
        BasicMultiServer.Packet packet = new BasicMultiServer.Packet();
        
        ClientHandler ch;
        public static string immediateIP;
        [SetUp]
        protected void SetUp()
        {
            IPAddress ipaddr = IPAddress.Parse("127.0.0.1");
            int portnum = 12345;
            TcpListener listener = new TcpListener(ipaddr, portnum);
            listener.Start();
            BasicMultiServer Basic = new BasicMultiServer();
            while (true)
            {
                Socket sock = listener.AcceptSocket();
                Console.WriteLine("Got connection");
                Console.WriteLine(sock.RemoteEndPoint.ToString());
                immediateIP = sock.RemoteEndPoint.ToString();
                ch = new ClientHandler(sock, Basic);
                ch.StartRead();
            }
        }
        [Test]
        public void ParseHandleTest()
        {
            string test = ch.ParseHandle("Hello World");
            Assert.AreEqual(test, "Hello World");
        }
        [Test]
        public void MakePongPacketTest()
        {
            BasicMultiServer.Packet test = new BasicMultiServer.Packet();
            test = ch.MakePongPacket(packet);
            int Test1 = test.descriptor;
            int Expected = 0;
            Assert.AreEqual(Expected, Test1);
        }


    }
}