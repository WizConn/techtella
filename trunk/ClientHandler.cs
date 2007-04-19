using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Techtella
{
    class ClientHandler
    {
        private byte[] buffer;
        private Socket sock;
        private NetworkStream netStream;
        private AsyncCallback readCB;
        private AsyncCallback writeCB;
        private const int bufferSize = 1024;
        private DateTime starttime, endtime;
        private string iHandle;
        private BasicMultiServer owner;
        private BasicMultiServer.Packet parsedPacket;
        public static int pongs = 0;

        public ClientHandler(Socket s, BasicMultiServer own)
        {
            owner = own;
            sock = s;
            buffer = new byte[bufferSize];
            netStream = new NetworkStream(s);

            readCB = new AsyncCallback(OnReadComplete);
            writeCB = new AsyncCallback(OnWriteComplete);
            starttime = DateTime.Now;
        }

        public void StartRead()
        {
            iHandle = BasicMultiServer.immediateIP;
            netStream.BeginRead(buffer, 0, buffer.Length, readCB, null);
        }

        private void OnReadComplete(IAsyncResult ar)
        {
            try
            {
                int bytesRead = netStream.EndRead(ar);

                if (bytesRead > 0)
                {
                    string s = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("Got {0} bytes from client: {1}", bytesRead, s);
                    ParsePacket(s);
                    if (parsedPacket.type == (byte)0)
                    {
                        Console.WriteLine("got ping");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        if (parsedPacket.ttl >= 0 && !owner.IsActive(parsedPacket) && iHandle != "127.0.0.1")
                        {
                            Console.WriteLine("forwarding ping");
                            owner.ForwardPing(parsedPacket, iHandle);
                            owner.AddActivePing(parsedPacket.descriptor);
                            Console.WriteLine("ponging back");
                            BasicMultiServer.Packet pong = MakePongPacket(parsedPacket);
                            owner.PongBack(pong, iHandle);
                        }
                    }
                    else if (parsedPacket.type == (byte)1)
                    {
                        pongs++;
                        Console.WriteLine("got pong");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        if (parsedPacket.ttl >= 0 && owner.IsActive(parsedPacket) && iHandle != "127.0.0.1")
                        {
                            Console.WriteLine("setting corresponding ping inactive");
                            owner.SetInactive(parsedPacket.descriptor);
                            owner.ForwardPong(parsedPacket);
                            if (parsedPacket.ttl < Client.TTL)
                            {
                                Console.WriteLine("adding known peer");
                                Console.WriteLine("MSG in parsedPacket:  " + parsedPacket.msg);
                                int pt = 0;
                                string port = parsedPacket.msg.Split('&')[0];
                                Console.WriteLine(port);
                                string host = parsedPacket.msg.Split('&')[1];
                                Console.WriteLine(host);
                                try
                                {
                                    pt = Int32.Parse(port);
                                }
                                catch (FormatException) { }
                                owner.AddFoundPeer(host, pt);
                            }
                        }
                    }
                    else if (parsedPacket.type == (byte)80)
                    {
                        Console.WriteLine("got query");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        if (parsedPacket.ttl >= 0 && !owner.IsQActive(parsedPacket) && iHandle != "127.0.0.1")
                        {
                            owner.ForwardQuery(parsedPacket, iHandle);
                            owner.AddActiveQuery(parsedPacket.descriptor);
                            if (true) // if (fileclass.gotsfile(parsedPacket.msg)) or some crap
                            {
                                BasicMultiServer.Packet qHit = MakeQHitPacket(parsedPacket);
                                owner.QHitBack(qHit, iHandle);
                            }
                        }
                        else if (iHandle == "127.0.0.1")
                        {
                            //Console.WriteLine("wont repeat query to loopback");
                        }
                    }
                    else if (parsedPacket.type == (byte)81)
                    {
                        Console.WriteLine("got query hit");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        if (parsedPacket.ttl >= 0 && owner.IsQActive(parsedPacket) && iHandle != "127.0.0.1")
                        {
                            owner.SetQInactive(parsedPacket.descriptor);
                            owner.ForwardQHit(parsedPacket);
                        }
                        else if (iHandle == "127.0.0.1")
                        {
                            //Console.WriteLine("wont repeat pong to loopback");
                        }
                        if (parsedPacket.descriptor == Client.MyQuery)
                        {
                            //**IMPLIMENT THIS**
                            //parse the query hit data and determine if a file is available
                            //the query hit data is formatted as follows
                            //a split('?')[5] will yeild the query hit packet
                            //a split('&')[0] = port
                            //[1] = address
                            //[2] = index (always 0)
                            //[3] = file size in bytes
                            //[4] = length of file name
                            //[5] = name of the file
                            //[6] = access code for the file's download
                        }
                    }
                    else if (parsedPacket.type == (byte)40)
                    {
                        //push?
                    }
                    else if (parsedPacket.type == (byte)123)
                    {
                        //chat packet
                        owner.AddChatMessage(parsedPacket.msg, iHandle);
                    }
                }
                else
                {
                    Console.WriteLine("Read connection dropped");
                    netStream.Close();
                    sock.Close();
                    netStream = null;
                    sock = null;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Connection closed forcibly by client.");
                netStream.Close();
                sock.Close();
                netStream = null;
                sock = null;
            }
            catch (NullReferenceException n)
            {
                //already handled, just don't crash
            }
        }

        public BasicMultiServer.Packet MakePongPacket(BasicMultiServer.Packet toPong)
        {
            string msg = "";
            msg += BasicMultiServer.filePort.ToString() + "&";
            string host = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(host);
            IPAddress[] addr = ipEntry.AddressList;
            string ipaddress = addr[0].ToString();
            msg += ipaddress + "&";
            msg += "0&";
            BasicMultiServer.Packet p = new BasicMultiServer.Packet();
            p.msg = msg;
            p.type = (byte)1;
            p.descriptor = parsedPacket.descriptor;
            return p;
        }

        public BasicMultiServer.Packet MakeQHitPacket(BasicMultiServer.Packet toQHit)
        {
            //port, address, index, size in bytes, length (of file name), name of file, code
            string msg = "";
            msg += BasicMultiServer.filePort.ToString() + "&";
            string host = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(host);
            IPAddress[] addr = ipEntry.AddressList;
            string ipaddress = addr[0].ToString();
            msg += ipaddress + "&";
            //**IMPLIMENT THIS**
            //somehow this method needs to access fileclass (which is now big and static)
            //it needs to search fileclass and generate the appropriate message for response
            //if a file is found it also needs to somehow cause a port to run on the server
            //for file transfer (but that comes later)
            msg += "0&"; //index
            msg += "0&"; //size in bytes
            msg += "0&"; //length(of file name)
            msg += "&0&"; //name of file (blank), code 0 (no download)
            BasicMultiServer.Packet p = new BasicMultiServer.Packet();
            p.msg = msg;
            p.type = (byte)71;
            p.descriptor = parsedPacket.descriptor;
            return p;
        }

        private void OnWriteComplete(IAsyncResult ar)
        {
            try
            {
                netStream.EndWrite(ar);
                Console.WriteLine("Write complete");
                netStream.BeginRead(buffer, 0, buffer.Length, readCB, null);
            }
            catch (IOException e)
            {
                Console.WriteLine("Connection closed forcibly by client.");
                netStream.Close();
                sock.Close();
                netStream = null;
                sock = null;
            }
        }

        public void ParsePacket(string s)
        {
            if (s[0] == '#' && s[1] == '#')
            {
                //this is a chat packet, do chatty things with it
                //must format into packet
                Console.WriteLine(s);
                parsedPacket.type = (byte)123;
                parsedPacket.msg = s;
            }
            else
            {
                string[] fields = s.Split('?');
                Console.WriteLine(fields);
                try
                {
                    parsedPacket.descriptor = Int32.Parse(fields[0]);
                    //Console.WriteLine("Descriptor: " + parsedPacket.descriptor);
                    parsedPacket.hops = Int32.Parse(fields[3]);
                    //Console.WriteLine("hops: " + parsedPacket.hops);
                    parsedPacket.length = fields[4].Length;
                    //Console.WriteLine("length: " + parsedPacket.length);
                    parsedPacket.msg = fields[4];
                    //Console.WriteLine("message: " + parsedPacket.msg);
                    parsedPacket.ttl = Int32.Parse(fields[2]);
                    //Console.WriteLine("ttl: " + parsedPacket.ttl);
                    parsedPacket.type = (byte)Int32.Parse(fields[1]);
                    //Console.WriteLine("type: " + parsedPacket.type);
                }
                catch (FormatException) { }
            }
        }
    }
}
