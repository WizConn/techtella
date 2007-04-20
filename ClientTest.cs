using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Management;

namespace Techtella
{
    [TestFixture]
    class ClientTest
    {

        [Test]
        public void PingTest()
        {
            Client.Ping("127.0.0.1", 12345);
            Assert.AreEqual(Client.pingCount, 1);
            
        }

        [Test]
        public void RePingTest()
        {
            Client.RePing("127.0.0.1", 12345, 1, 1, 987654321);
            
        }


        [Test]
        public void QueryTest()
        {
            Client.Query("127.0.0.1", 12345, 1, "Stuff");
            Assert.AreEqual(Client.pingCount, 1);
        }

        [Test]
        public void ReQueryTest()
        {
            Client.ReQuery("127.0.0.1", 12345, 1, 1, 987654321, "Stuff");
        }
        
    }
}
