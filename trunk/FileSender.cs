using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Techtella
{
    public class FileSender
    {
        public static string clientIP;
        public static string myFile;
        public static Int64 fileCompleteness;
        public static long bytesPerSecond;
        public static int attempted = 0;
        public static int completed = 0;
        public static long totalSent = 0;
        public static long fileSize = 0;
        public FileSender(string myClientIpAddr, string filename)
        {
            clientIP = myClientIpAddr;
            myFile = filename;
            Console.WriteLine("FileSender created");
            fileCompleteness = 0;
            bytesPerSecond = 0;
        }

        public void Run()
        {
            ClientHandler.uploadInProgress = 1;
            Console.WriteLine("Starting File Sender");
            string myHost = System.Net.Dns.GetHostName();
            string myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[0].ToString();
            IPAddress ipaddr = IPAddress.Parse(myIP);
            Console.WriteLine("IPADDR: " + myIP);
            Console.WriteLine("PORT: " + BasicMultiServer.filePort);
            TcpListener listener = new TcpListener(ipaddr, BasicMultiServer.filePort);
            listener.Start();
            Socket sock = listener.AcceptSocket();
            Console.WriteLine("Got FileSender connection");
            Console.WriteLine(sock.RemoteEndPoint.ToString());
            HandleClient(sock);
            Console.WriteLine("Disconnecting");
            sock.Close();
        }

        private void HandleClient(Socket sock)
        {
            attempted++;
            DateTime then = DateTime.Now;
            DateTime now = DateTime.Now;
            Console.WriteLine("HandleClient called");
            NetworkStream netStream = new NetworkStream(sock);
            FileStream fs = new FileStream(FileClass.GetFilePath(myFile) + myFile, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            fileSize = fs.Length;
            byte[] data = new byte[1];
            Console.WriteLine("Waiting for handshake");
            netStream.Read(data, 0, 1);
            Console.WriteLine("Got handshake, shaking back");
            netStream.Write(data, 0, 1);
            Console.WriteLine("Sending data, hope it gets there");
            StreamWriter writer = new StreamWriter(netStream);
            Int64 bytesSent = 0;
            writer.WriteLine(fs.Length);
            fs.Position = 0;
            long bytesthen = 0;
            while (bytesSent < fs.Length + 10000)
            {
                then = now;
                now = DateTime.Now;
                int seconds = ((TimeSpan)(now - then)).Seconds;
                if (seconds >= 1)
                {
                    long bytediff = bytesSent - bytesthen;
                    bytesthen = bytesSent;
                    bytesPerSecond = bytediff / seconds;
                }
                if (bytesSent < fs.Length)
                {
                    writer.WriteLine(fs.ReadByte());
                    netStream.Flush();
                    Console.Write("So far i sent " + bytesSent++ + " bytes\r");
                    fileCompleteness = bytesSent;
                }
                else
                {
                    writer.WriteLine((byte)0);
                    Console.Write("Sending safety bytes\r");
                    if (netStream.DataAvailable)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
            if (bytesSent == fs.Length)
            {
                Console.WriteLine("Wrote Entire File " + bytesSent + " vs " + fs.Length);
                completed++;
                totalSent += bytesSent;
            }
            else if (bytesSent > fs.Length)
            {
                Console.WriteLine("Got more data: " + bytesSent + " vs " + fs.Length);
                totalSent += bytesSent;
            }
            else
            {
                Console.WriteLine("File is incomplete at " + bytesSent + " bytes, " + fs.Length + " needed");
                totalSent += bytesSent;
            }
            Console.WriteLine("\nWrite complete, waiting for final handshake");
            netStream.Read(data, 0, 1);
            netStream.Close();
            Console.WriteLine("Wrote entire file");
            ClientHandler.uploadInProgress = 0;
        }
    }
}