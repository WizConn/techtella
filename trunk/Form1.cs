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
        public Statistics stats = new Statistics();
        public BasicMultiServer server;
        public ArrayList testList = new ArrayList();
        public ArrayList listFiles = new ArrayList();
        public static String chatIP;
        public static int chatPort;
        public static String knownPeerIP;
        public static int knownPeerPort;
        public static String foundPeerIP;
        public static int foundPeerPort;
        public GUIUpdate updater;
        public String selectedCategory = "ANY";
        public static String[] category = { "ANY", "AUDIO", "VIDEO", "DATA", "TEXT", "IMAGE" };
        public static String[] searchCategory = { "ANY", "AUDIO", "VIDEO", "DATA", "TEXT", "IMAGE" };
        public static string fileName = "";
        public static string filePath = "";
        public static string title = "";
        public static string sharedCategory = "";
        public static string file;
        public static String tempFilePath;
        public static DataGridViewRow removeRow;


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

        public void SearchFiller(ArrayList list)
        {
            foreach (string result in list)
            {
                string[] row = { "", "", "", "" };
                int i = 0;
                foreach (string col in result.Split('*'))
                {
                    row.SetValue(col, i);
                    i++;
                }
                //row.SetValue("0", 2);
                searchData.Rows.Add(row);
            }
        }

        public void UpdateFoundPeers() 
        {
            //update found peers here
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
                        knownPeerIP = tempRow[0].Value.ToString();
                        string temp = tempRow[1].Value.ToString();
                        try
                        {
                            knownPeerPort = int.Parse(temp);
                        }
                        catch { }
                    }
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
            //else if (sender == sharedData)
            //{
            //    removeRow = sharedData.CurrentRow;
            //    if (removeRow.Cells[0] != null)
            //    {
            //        tempFileName = removeRow.Cells[0].Value.ToString();
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == peersRefreshButton)
            {
                try
                {
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
                catch (NullReferenceException) { }
            }

            else if (sender == chatSendButton)
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
                chatInputBox.Text = "";
            }
            else if (sender == forcePingButton)
            {
                if (knownPeerIP == null)
                {
                    DataGridViewCellCollection tempRow = knownPeersData.CurrentRow.Cells;
                    if (tempRow[0] != null && tempRow[1] != null)
                    {

                        knownPeerIP = tempRow[0].Value.ToString();
                        string temp = tempRow[1].Value.ToString();
                        Console.WriteLine(tempRow);
                        try
                        {
                            knownPeerPort = int.Parse(temp);
                        }
                        catch { }
                    }
                }
                server.CreatePing(knownPeerIP, knownPeerPort);
            }
            else if (sender == browseButton)
            {
                openFileDialog1.ShowDialog();
            }
            else if (sender == addSharedFileButton)
            {
                file = category[shareCategoryCombo.SelectedIndex] + "*" + shareTitleBox.Text + "*" + shareFileBox.Text;
                FileClass.AddFile(file);
                try
                {
                    string[] row = { "", "", "", "", "" };
                    int i = 0;
                    foreach (string col in file.Split('*'))
                    {
                        if (i == 0)
                        {
                            sharedCategory = col;
                        }
                        else if (i == 1)
                        {
                            title = col;
                        }
                        else if (i == 2)
                        {
                            filePath = col;
                        }
                        fileName = filePath.Split('\\')[filePath.Split('\\').Length-1];
                        i++;
                    }
                    row.SetValue(fileName, 0);
                    row.SetValue(sharedCategory, 1);
                    row.SetValue(title, 2);
                    row.SetValue("?", 3);
                    row.SetValue("?", 4);
                    sharedData.Rows.Add(row);
                    
                }
                catch (NullReferenceException) { }
            }
            else if (sender == searchButton)
            {
                String searchQuery = searchCategory[searchCategoryCombo.SelectedIndex] + "*" + searchTitleBox.Text + "*" + searchFileNameBox.Text;
                Console.WriteLine(searchQuery);
                server.CreateQuery(searchQuery);
            }
            else if (sender == removeButton)
            {
                listFiles = FileClass.GetFileData();
                tempFilePath = listFiles[sharedData.CurrentRow.Index].ToString();
                sharedData.Rows.Remove(sharedData.CurrentRow);
                FileClass.RemoveFile(tempFilePath);
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
            else if (sender == settingsToolStripMenuItem)
            {
                Settings settings = new Settings();
                settings.ShowDialog();
            }
            
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {/*
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
                    chatInputBox.Text = "";
                }
            }
        */
        }

        public void updateStats()
        {
            pingStat.Text = stats.numPing + "";
            pongStat.Text = stats.numPong + "";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            shareFileBox.Text = "" + openFileDialog1.FileName;
        }

        private void shareCategoryCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedCategory = e.ToString();
        }
    }
}