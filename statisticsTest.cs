using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System.Collections;
using NUnit.Framework;

namespace Techtella
{   
    [TestFixture]
    class statisticsTest
    {
        Statistics A1;
        Statistics A2;
        [SetUp]
        protected void Setup()
        {
            A1 = new Statistics();
            A2 = new Statistics();
        }
        [Test]
        public void OverallTest()
        {
            A1.numPing = 3;
            int Actual1 = 3;
            int actual2 = 0;
            /*ArrayList Actual = new ArrayList();
            Actual.Add("Wii");
            ArrayList Test = new ArrayList();
            A2.FilesToDownload = ;
            */
            Assert.AreEqual(Actual1, A1.numPing);
            Assert.AreEqual(actual2,A1.numPong);
        }



    }







}