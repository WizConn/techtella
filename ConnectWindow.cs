using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Collections;

namespace Techtella
{
    public partial class ConnectWindow : Form
    {
        bool noException = true;
        public BasicMultiServer server;

        public ConnectWindow(BasicMultiServer m)
        {
            InitializeComponent();
            server = m;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender == connectButton)
            {
                string ip = connectPeerIPBox.Text;
                int port = 12345;
                int successCode = 0;
                
                try
                {
                    successCode = server.CreatePing(ip, port);
                    if (successCode == 0)
                    {
                        throw new SocketException();
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to find a peer at " + ip + ":" + port);
                    noException = false;
                    connectPeerIPBox.Text = "";
                }
                if (noException)
                {
                    server.AddKnownPeer(ip, port);
                    this.Close();
                }
                else
                {
                    noException = true;
                }
                
            }
            else if (sender == cancelButton)
            {
                this.Close();
            }
             
        }

        private void ConnectWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}