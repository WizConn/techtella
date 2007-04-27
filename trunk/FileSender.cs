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
        private string clientIP;
        private string myFile;
        public FileSender(string myClientIpAddr, string filename)
        {
            clientIP = myClientIpAddr;
            myFile = filename;
            Console.WriteLine("FileSender created");
        }

        public void Run()
        {
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
            Console.WriteLine("HandleClient called");
            NetworkStream netStream = new NetworkStream(sock);
            FileStream fs = new FileStream(myFile, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            byte[] data = new byte[1024];
            byte[] bytesize = new byte[2];
            int byteToSend;
            Int16 bytelen = 0;
            Console.WriteLine("Waiting for handshake");
            netStream.Read(data, 0, 1);
            Console.WriteLine("Got handshake, shaking back");
            netStream.Write(data, 0, 1);
            Console.WriteLine("Sending data, hope it gets there");


            while (!sr.EndOfStream)
            {
                bytelen = 0;
                for (int i = 0; i < 1024; i++)
                {
                    if (!sr.EndOfStream)
                    {
                        byteToSend = sr.Read();
                        data[i] = (byte)byteToSend;
                        bytelen++;
                    }
                    else
                    {
                        data[i] = 0;
                    }
                }
                bytesize = BitConverter.GetBytes(bytelen);
                Console.Write("Sent a " + bytelen + " byte packet with bytes" + bytesize[0] + " and " + bytesize[1] + "\r");
                netStream.Write(bytesize, 0, 2);
                netStream.Write(data, 0, 1024);
            }
            netStream.Close();
            Console.WriteLine("Wrote entire file");
        }
    }
}