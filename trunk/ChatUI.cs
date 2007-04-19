using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Techtella
{
    public partial class Chat : Form
    {
        string ClientIP;
        int PortNum;

        public Chat(string ip, int port)
        {
            ClientIP = ip;
            PortNum = port;
            InitializeComponent();
        }

        private void InputText(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                Client.SendMsg(ClientIP, PortNum, input.Text);
                input.Text = "";
            }
        }

        private void ChatClick(object sender, EventArgs e)
        {
            Client.SendMsg(ClientIP, PortNum, input.Text);
            input.Text = "";
        }
   }
}