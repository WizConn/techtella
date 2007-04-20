using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Techtella
{
    public partial class Form1 : Form
    {
        //public Statistics stats = new Statistics();
        public BasicMultiServer server;
        public ArrayList testList = new ArrayList();
        public static String chatIP;
        public static int chatPort;
        public GUIUpdate updater;
        
        public Form1(BasicMultiServer m)
        {
            Thread th = new Thread(new ThreadStart(DoSplash));
            updater = new GUIUpdate(m, this);
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);
            server = m;
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            updater.RunThreaded();
        }

        public void SetText(string output)
        {
            chatOutputBox.Text = output;
        }

        public void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender == knownPeersData)
            {
                DataGridViewCellCollection tempRow = knownPeersData.CurrentRow.Cells;
                if (tempRow[0] != null && tempRow[1] != null)
                {
                    chatIP = tempRow[0].Value.ToString();
                    string temp = tempRow[1].Value.ToString();
                    try
                    {
                        chatPort = int.Parse(temp);
                    }
                    catch { }
                }
                Console.WriteLine(chatIP);
                Console.WriteLine(chatPort);
            }
            else if (sender == knownPeersChatData)
            {
                DataGridViewCellCollection tempRow = knownPeersChatData.CurrentRow.Cells;
                if (tempRow[0] != null && tempRow[1] != null)
                {

                    chatIP = tempRow[0].Value.ToString();
                    string temp = tempRow[1].Value.ToString();
                    Console.WriteLine(tempRow);
                    try
                    {
                        chatPort = int.Parse(temp);
                    }
                    catch { }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == peersRefreshButton) {
                try{
                    foreach (string peer in server.foundPeers)
                    {
                        string[] row = { "", "", "" };
                        int i = 0;
                        foreach (string col in peer.Split('_'))
                        {
                            row.SetValue(col, i);
                            i++;
                        }
                        row.SetValue("0", 2);
                        peersData.Rows.Add(row);
                    }
                }
                catch(NullReferenceException){}
            }
            else if (sender == refreshStatsButton)
            {
                pingStat.Text = Client.statPing.ToString();
                pongStat.Text = Client.statPong.ToString();
               // queryStat.Text = "" + stats.numQuery;
                //Need queryhit and push as well
            }
            else if (sender == chatSendButton)
            {
                Console.WriteLine(chatIP);
                Client.SendMsg(chatIP, chatPort, chatInputBox.Text);
                if (chatOutputBox.Text == "")
                {
                    updater.owner.chatMessages.Add("You: " + chatInputBox.Text + "\r\n");
                    //chatOutputBox.Text = "You: " + chatInputBox.Text;
                }
                else
                {
                    updater.owner.chatMessages.Add("You: " + chatInputBox.Text + "\r\n");
                    //chatOutputBox.Text += "\r\n" + "You: " + chatInputBox.Text;
                }
                chatInputBox.Text = "";
            }
            else if (sender == forcePingButton)
            {
                server.CreatePing(chatIP, chatPort);
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == aboutTechtellaToolStripMenuItem)
            {
                About about = new About();
                about.ShowDialog();
            }
            else if (sender == exitToolStripMenuItem)
            {
                this.Close();
            }
            else if (sender == connectToolStripMenuItem)
            {
                ConnectWindow connectWindow = new ConnectWindow(server);
                connectWindow.ShowDialog();
                if (Client.pingCount > 0)
                {
                    tabControl.Enabled = true;
                    connectToolStripMenuItem.Enabled = false;
                    disconnectToolStripMenuItem.Enabled = true;
                    char[] delimit = new char[] { '_' };
                    foreach (string peer in server.knownPeers)
                    {
                        string[] row = {"","",""};
                        string[] row2 = { "", "" };
                        int i = 0;
                        foreach (string col in peer.Split(delimit))
                        {
                            row.SetValue(col, i);
                            row2.SetValue(col, i);
                            i++;
                        }
                        row.SetValue("0", 2);
                        knownPeersData.Rows.Add(row);
                        knownPeersChatData.Rows.Add(row2);
                    }
                    
                    
                }
            }
            
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (sender == chatInputBox)
                {
                    if (chatIP == null)
                    {
                        DataGridViewCellCollection tempRow = knownPeersChatData.CurrentRow.Cells;
                        if (tempRow[0] != null && tempRow[1] != null)
                        {

                            chatIP = tempRow[0].Value.ToString();
                            string temp = tempRow[1].Value.ToString();
                            Console.WriteLine(tempRow);
                            try
                            {
                                chatPort = int.Parse(temp);
                            }
                            catch { }
                        }
                    }
                    Client.SendMsg(chatIP, chatPort, chatInputBox.Text);
                    updater.owner.chatMessages.Add("You: " + chatInputBox.Text + "\r\n");
                    //chatOutputBox.Text += "\r\n" + "You: " + chatInputBox.Text;
                    chatInputBox.Text = "";
                }
            }
        }
    }
}