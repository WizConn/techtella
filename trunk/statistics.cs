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
        public int numFilesSent;
        public int numBytesSent;
        public int numBytesReceived;
        public int numPeers;
        public ArrayList peerAddr;
        public ArrayList filesToDownload;
        public ArrayList timesDownloaded;
        #endregion

        #region Constructor
        public Statistics()
        {
            numPing=numPong=numQuery=numFilesSent=numBytesSent=numBytesReceived=numPeers = 0;
            peerAddr = new ArrayList();
            filesToDownload = new ArrayList();
            timesDownloaded = new ArrayList();
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
        /*
        public ArrayList PeerAddr
        {
            get { return peerAddr; }
        }
        public ArrayList AddPeerAddr
        {
            set { peerAddr.Add(value); }
        }
        public ArrayList FilesToDownload
        {
            get { return filesToDownload; }
        }
        public ArrayList AddFilesToDownload
        {
            set { filesToDownload.Add(value); }
        }
        public ArrayList TimesDownloaded
        {
            get { return timesDownloaded; }
        }
        public ArrayList AddTimesDownloaded
        {
            set { timesDownloaded.Add(value); }
        }*/
        #endregion

        public void statisticsUpdate()
        {
            numPing = Client.statPing;
            numPong = Client.statPong;
            numQuery = ClientHandler.statQuery;
            numQueryHit = ClientHandler.statQueryHit;
        }
    }
}
