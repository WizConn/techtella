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
        string[] row1 = { "192.168.1.100", "54321", "0" };
        
        public Form1(BasicMultiServer m)
        {
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);
            server = m;
            InitializeComponent();
        }

        public void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        private void startBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                pingStat.Text = Client.pingCount.ToString();
                pongStat.Text = Client.pongCount.ToString();
               // queryStat.Text = "" + stats.numQuery;
                //Need queryhit and push as well
            }
            else if (sender == chatButton)
            {
                if (chatIP != null)
                {
                    Chat chat = new Chat(chatIP, chatPort);
                    chat.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statsSharedData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                        int i = 0;
                        foreach (string col in peer.Split(delimit))
                        {
                            row.SetValue(col, i);
                            i++;
                        }
                        row.SetValue("0", 2);
                        knownPeersData.Rows.Add(row);
                    }
                    
                    
                }
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}