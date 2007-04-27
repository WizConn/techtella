using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Techtella
{
    public class FileReceiver
    {
        private string clientIP;
        private string myFile;
        private int filePort;
        public FileReceiver(string myClientIpAddr, int portnum, string filename)
        {
            clientIP = myClientIpAddr;
            myFile = filename;
            filePort = portnum;
            Console.WriteLine("FileReceiver created");
        }

        private void Run()
        {
            Console.WriteLine("Starting File Receiver");
            Console.WriteLine("IPADDR: " + clientIP);
            Console.WriteLine("PORT: " + filePort);
            bool connected = false;
            TcpClient tc = new TcpClient(clientIP, 12345);
            NetworkStream ns = tc.GetStream();
            while (!connected)
            {
                try
                {
                    Console.WriteLine("Trying to Connect:" + clientIP + ":" + filePort);
                    tc = new TcpClient(clientIP, filePort);
                    ns = tc.GetStream();
                    connected = true;
                }
                catch
                {
                    Console.WriteLine("Failed");
                    connected = false;
                }
            }
            Console.WriteLine("Success");
            FileStream fs = new FileStream(myFile, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            byte[] buffer = new byte[1];
            Console.WriteLine("Sending handshake");
            ns.Write(buffer, 0, 1);
            Console.WriteLine("Waiting for handshake");
            ns.Read(buffer, 0, 1);
            Console.WriteLine("Got handshake, hope i get data!");
            int GettingData = 1;
            Int64 bytesGot = 0;
            while (GettingData > 0)
            {
                GettingData = ns.Read(buffer, 0, 1);
                if(GettingData > 0)
                {
                    Console.Write("So far i got " + bytesGot++ + " bytes\r");
                    sw.Write((char)buffer[0]);
                }
            } 
            Console.WriteLine("Received Entire File");
            ns.Close();
            tc.Close();
            sw.Close();
            fs.Close();
            Console.WriteLine("Download Complete");
        }

        public void RunThreaded()
        {
            Thread threadedRun = new Thread(Run);
            threadedRun.Start();
        }
    }
}