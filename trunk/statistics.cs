using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;
using System.Collections;

namespace Techtella
{
    public class Statistics
    {
        #region InstanceVariables
        public int numPing;
        public int numPong;
        public int numQuery;
        public int numQueryHit;
        public int numPush;
        public int numFilesSent;
        public int numBytesSent;
        public int numBytesReceived;
        public int numPeers;
        public ArrayList peerAddr;
        #endregion

        #region Constructor
        public Statistics()
        {
            numPing=numPong=numQuery=numFilesSent=numBytesSent=numBytesReceived=numPeers = 0;
            peerAddr = new ArrayList();
        }
        #endregion

        #region Properties
        public int NumPing
        {
            get { return numPing; }
            set { numPing = value; }
        }
        public int NumPong
        {
            get { return numPong; }
            set { numPong = value; }
        }
        public int NumQuery
        {
            get { return numQuery; }
            set { numQuery = value; }
        }
        public int NumFilesSent
        {
            get { return numFilesSent; }
            set { numFilesSent = value; }
        }
        public int NumBytesSent
        {
            get { return numBytesSent; }
            set { numBytesSent = value; }
        }
        public int NumBytesReceived
        {
            get { return numBytesReceived; }
            set { numBytesReceived = value; }
        }
        public int NumPeers
        {
            get { return numPeers; }
            set { numPeers = value; }
        }
        #endregion

        public void statisticsUpdate()
        {
            numPing = Client.statPing;
            numPong = Client.statPong;
            numQuery = ClientHandler.statQuery;
            numQueryHit = ClientHandler.statQueryHit;
            numPush = Client.statPush;
            numBytesSent = (int)FileSender.totalSent;
            numBytesReceived = (int)FileReceiver.totalReceived;
        }
    }
}
