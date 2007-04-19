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
        int pt;
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
                string port = connectPeerPortBox.Text;
                try
                {
                    pt = int.Parse(port);
                }
                catch (FormatException) { }
                try
                {
                    int descriptor = Client.descriptorHash * 100 + Client.pingCount + 1;
                    server.AddActivePing(descriptor, "127.0.0.1");
                    Client.Ping(ip, pt);
                }
                catch
                {
                    MessageBox.Show("Unable to find a peer at " + ip + ":" + port);
                    noException = false;
                    connectPeerIPBox.Text = "";
                    connectPeerPortBox.Text = "";
                }
                if (noException)
                {
                    server.AddKnownPeer(ip, pt);
                    this.Close();
                }
                
            }
            else if (sender == cancelButton)
            {
                this.Close();
            }
             
        }
    }
}