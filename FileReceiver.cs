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
            StreamReader reader = new StreamReader(ns);
            Int64 bytesGot = 0;
            Int64 fileLength = Int64.Parse(reader.ReadLine());
            while (bytesGot < fileLength)
            {
                try
                {
                    fs.WriteByte(Byte.Parse(reader.ReadLine()));
                    fs.Flush();
                    Console.Write("So far i got " + bytesGot++ + " bytes\r");
                }
                catch
                {
                    Console.Write("Waiting for data.                    \r");
                }
            }
            Console.WriteLine();
            if (bytesGot == fileLength)
            {
                Console.WriteLine("Received Entire File: " + bytesGot + " vs " + fileLength);
            }
            else if (bytesGot > fileLength)
            {
                Console.WriteLine("Got more data: " + bytesGot + " vs " + fileLength);
            }
            else
            {
                Console.WriteLine("File is incomplete");
            }
            Console.WriteLine("\nPerforming final handshake");
            ns.Write(buffer, 0, 1);
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