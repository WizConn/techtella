using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Techtella
{
    public class FileReceiver
    {
        public static string clientIP;
        public static string myFile;
        public static int filePort;
        public static long bytesPerSecond;
        public static long fileCompleteness;
        public static long totalReceived = 0;
        public static int attempted = 0;
        public static int completed = 0;
        public static long fileSize = 0;
        public FileReceiver(string myClientIpAddr, int portnum, string filename)
        {
            clientIP = myClientIpAddr;
            myFile = filename;
            filePort = portnum;
            Console.WriteLine("FileReceiver created");
            fileCompleteness = 0;
            bytesPerSecond = 0;
        }

        private void Run()
        {
            try
            {
                ClientHandler.downloadInProgress = 1;
                Console.WriteLine("Starting File Receiver");
                Console.WriteLine("IPADDR: " + clientIP);
                Console.WriteLine("PORT: " + filePort);
                bool connected = false;
                TcpClient tc = new TcpClient(clientIP, 12345);
                NetworkStream ns = tc.GetStream();
                DateTime then = DateTime.Now;
                DateTime now = DateTime.Now;
                bool deadConnection = false;
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
                    now = DateTime.Now;
                    if (((TimeSpan)(now - then)).Seconds >= 5)
                    {
                        MessageBox.Show("The host at " + clientIP + " doesn't have the full version, and cannot upload files simultaneously");
                        deadConnection = true;
                        break;
                    }
                }
                if (!deadConnection)
                {
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
                    fileSize = fileLength;
                    then = DateTime.Now;
                    now = DateTime.Now;
                    long bytesthen = 0;
                    attempted++;
                    DateTime timeOutThen = DateTime.Now;
                    DateTime timeOutNow = DateTime.Now;
                    while (bytesGot < fileLength)
                    {
                        now = DateTime.Now;
                        fileCompleteness = bytesGot;
                        int seconds = ((TimeSpan)(now - then)).Seconds;
                        if (seconds >= 1)
                        {
                            long bytediff = bytesGot - bytesthen;
                            bytesthen = bytesGot;
                            bytesPerSecond = bytediff / seconds;
                            then = now;
                        }
                        try
                        {
                            fs.WriteByte(Byte.Parse(reader.ReadLine()));
                            fs.Flush();
                            Console.Write("So far i got " + bytesGot++ + " bytes\r");
                            timeOutThen = DateTime.Now;
                        }
                        catch
                        {
                            Console.Write("Waiting for data.                    \r");
                            timeOutNow = DateTime.Now;
                            if (((TimeSpan)(timeOutNow - timeOutThen)).Seconds > 10)
                            {
                                MessageBox.Show("The host at " + clientIP + " doesn't appear to be alive anymore. Aborting download.");
                                deadConnection = true;
                                break;
                            }
                        }
                    }
                    if (!deadConnection)
                    {
                        Console.WriteLine();
                        if (bytesGot == fileLength)
                        {
                            Console.WriteLine("Received Entire File: " + bytesGot + " vs " + fileLength);
                            completed++;
                            totalReceived += bytesGot;
                            fileCompleteness = bytesGot;
                        }
                        else if (bytesGot > fileLength)
                        {
                            Console.WriteLine("Got more data: " + bytesGot + " vs " + fileLength);
                            totalReceived += bytesGot;
                            fileCompleteness = bytesGot;

                        }
                        else
                        {
                            Console.WriteLine("File is incomplete");
                            totalReceived += bytesGot;
                            fileCompleteness = bytesGot;
                        }
                        Console.WriteLine("\nPerforming final handshake");
                        ns.Write(buffer, 0, 1);
                    }
                    ns.Close();
                    tc.Close();
                    sw.Close();
                    fs.Close();
                    Console.WriteLine("Download Complete");
                }
                ClientHandler.downloadInProgress = 0;
            }
            catch (SocketException e)
            {
                MessageBox.Show("Host is unavailable");
                Console.WriteLine(e);
            }
        }

        public void RunThreaded()
        {
            Thread threadedRun = new Thread(Run);
            threadedRun.Start();
        }
    }
}