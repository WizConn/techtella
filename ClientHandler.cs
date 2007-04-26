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
        private string iHandle;
        private BasicMultiServer owner;
        private BasicMultiServer.Packet parsedPacket;
        public static int pongs = 0;
        public static int statQuery = 0;
        public static int statQueryHit = 0;

        public ClientHandler(Socket s, BasicMultiServer own)
        {
            owner = own;
            sock = s;
            buffer = new byte[bufferSize];
            netStream = new NetworkStream(s);

            readCB = new AsyncCallback(OnReadComplete);
            writeCB = new AsyncCallback(OnWriteComplete);
        }

        public void StartRead()
        {
            iHandle = BasicMultiServer.immediateIP;
            try
            {
                netStream.BeginRead(buffer, 0, buffer.Length, readCB, null);
            }
            catch { }
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
                        owner.AddFoundPeer(iHandle, 12345);
                        Console.WriteLine("got ping");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        if (parsedPacket.ttl >= 0 && !owner.IsActive(parsedPacket))
                        {
                            Console.WriteLine("TTL:  " + parsedPacket.ttl);
                            Console.WriteLine("forwarding ping");
                            owner.ForwardPing(parsedPacket, iHandle);
                            owner.AddActivePing(parsedPacket.descriptor, iHandle);
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
                        if (owner.IsActive(parsedPacket))
                        {
                            //Console.WriteLine("setting corresponding ping inactive");
                            //owner.SetInactive(parsedPacket.descriptor);
                            Console.WriteLine("forwarding pong");
                            owner.ForwardPong(parsedPacket, iHandle);
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
                            Console.WriteLine("adding found peer");
                            owner.AddFoundPeer(parsedPacket.msg.Split('&')[1] + ":" + parsedPacket.msg.Split('&')[0], 12345);
                        }
                    }
                    else if (parsedPacket.type == (byte)80)
                    {
                        statQuery++;
                        Console.WriteLine("got query");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        owner.AddFoundPeer(iHandle, 12345);
                        if (!owner.IsQActive(parsedPacket))
                        {
                            Console.WriteLine("Adding Active Query");
                            owner.AddActiveQuery(parsedPacket.descriptor);
                        }
                        if (parsedPacket.ttl >= 0)
                        {
                            Console.WriteLine("Forwarding Query");
                            owner.ForwardQuery(parsedPacket, iHandle);
                            if (FileClass.HasFile(parsedPacket.msg) > 0)
                            {
                                Console.WriteLine("I have this file!\nMaking QHit Packet.");
                                BasicMultiServer.Packet qHit = MakeQHitPacket(parsedPacket);
                                Console.WriteLine("Sending QHit");
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
                        statQueryHit++;
                        Console.WriteLine("got query hit");
                        parsedPacket.ttl--;
                        parsedPacket.hops++;
                        owner.AddFoundPeer(iHandle, 12345);
                        if (owner.IsQActive(parsedPacket))
                        {
                            owner.ForwardQHit(parsedPacket, iHandle);
                        }
                        Console.WriteLine("MyQuery = " + Client.MyQuery + " descriptor = " + parsedPacket.descriptor);
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
                            string qhitpacket = parsedPacket.msg;
                            //owner.AddQueryHit(parsedPacket.msg);
                            Console.WriteLine("Added a network file. GG MOTHAFUCKA!!");
                            FileClass.AddNetFile(qhitpacket.Split('&')[5], Int32.Parse(qhitpacket.Split('&')[6]), qhitpacket.Split('&')[1] + ":" + qhitpacket.Split('&')[0]);
                        }
                    }
                    else if (parsedPacket.type == (byte)40)
                    {
                        //push?
                    }
                    else if (parsedPacket.type == (byte)123)
                    {
                        //chat packet
                        owner.AddFoundPeer(iHandle.Split(':')[0], 12345);
                        owner.AddChatMessage(parsedPacket.msg + "\n", iHandle);
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
                Console.WriteLine("Connection closed forcibly by client.\n" + e);
                netStream.Close();
                sock.Close();
                netStream = null;
                sock = null;
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine("BLAH!\n" + n);
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
            msg += "0&"; //index, always 0
            msg += "0&"; //size in bytes
            msg += toQHit.msg.Split('*')[2].Length + "&"; //length(of file name)
            msg += toQHit.msg.Split('*')[2] + "&0&"; //name of file (blank), code 0 (no download)
            BasicMultiServer.Packet p = new BasicMultiServer.Packet();
            p.msg = msg;
            p.type = (byte)81;
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
                Console.WriteLine("Connection closed forcibly by client.\n" + e);
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
                    parsedPacket.length = fields[5].Length;
                    //Console.WriteLine("length: " + parsedPacket.length);
                    parsedPacket.msg = fields[5];
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
