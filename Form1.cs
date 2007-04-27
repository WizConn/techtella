using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

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
        public static String movePeerIP;
        public static int movePeerPort;
        public static String senderIP;
        public static int senderPort;
        public static string senderFilename;
        public static string transferIP;
        public static string transferPort;
        public static string transferFilename;
        public static string transferFilesize;
        public static string transferProgress;
        public static string transferStatus;
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
            string myHost = System.Net.Dns.GetHostName();
            string myIP = System.Net.Dns.GetHostEntry(myHost).AddressList[0].ToString();
            yourIP.Text = myIP;

        }

        public struct Transfer
        {
            public string type;         //either download or upload
            public string filename;
            public string status;       //either downloading, uploading, finished, or aborted
            public int size;            //size of file
            public int completed;       //bytes downloaded/uploaded
            public decimal speed;       //speed in kBps
            public string ip;           //ip of other person
            public string port;         //port of other
        }

        public void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }

        public void SetText(string output)
        {
            chatOutputBox.Text = output;
        }

        public void UpdateDownloaders()
        {
            downloadersBox.Text += ClientHandler.pushIP;
        }

        public void UpdateDownloads()
        {
            try
            {
                string[] row = { "", "", "", "", "", "", "", "" };

                row[0] = FileReceiver.myFile;
                if (ClientHandler.downloadInProgress == 1)
                    row[1] = "Downloading";
                else
                    row[1] = "n/a";
                row[2] = ((int)(((double)FileReceiver.fileCompleteness / FileReceiver.fileSize) * 100)).ToString() + "%";
                row[3] = FileReceiver.fileSize + " bytes";
                row[4] = FileReceiver.fileCompleteness + " bytes";
                row[5] = "" + FileReceiver.bytesPerSecond;
                row[6] = FileReceiver.clientIP;
                row[7] = "" + FileReceiver.filePort;
                if (downloadData.Rows.Count < 1 && ClientHandler.downloadInProgress == 1)
                {
                    downloadData.Rows.Add(row);
                }
                foreach (DataGridViewRow currentRow in downloadData.Rows)
                {
                    if (currentRow.Cells[0].Value.ToString() == row[0])
                    {
                        currentRow.SetValues(row);
                    }
                }
            }
            catch
            {

            }
        }

        public void UpdateUploads()
        {
            try
            {
                string[] row = { "", "", "", "", "", "", "", "" };

                row[0] = FileSender.myFile;
                if (ClientHandler.uploadInProgress == 1)
                    row[1] = "Uploading";
                else
                    row[1] = "n/a";
                row[2] = ((int)(((double)FileSender.fileCompleteness / FileSender.fileSize) * 100)).ToString() + "%";
                row[3] = FileSender.fileSize + " bytes";
                row[4] = FileSender.fileCompleteness + " bytes";
                row[5] = "" + FileSender.bytesPerSecond;
                row[6] = FileSender.clientIP;
                row[7] = "" + BasicMultiServer.filePort;
                if (uploadData.Rows.Count < 1 && ClientHandler.uploadInProgress == 1)
                {
                    uploadData.Rows.Add(row);
                }
                foreach (DataGridViewRow currentRow in uploadData.Rows)
                {
                    if (currentRow.Cells[0].Value.ToString() == row[0])
                    {
                        currentRow.SetValues(row);
                    }
                }
            }
            catch
            {

            }
        }

        public void SearchFiller(ArrayList filenamelist, ArrayList hostlist, ArrayList codeslist)
        {
            try
            {
                int i = 0;
                //ArrayList filenames = (ArrayList)filenamelist.Clone();
                foreach (object result in filenamelist)
                {
                    string[] row = { "", "", "", "" };
                    row.SetValue(result.ToString().Split('|')[0], 0);
                    row.SetValue(result.ToString().Split('|')[1], 1);
                    row.SetValue(hostlist[i].ToString(), 2);
                    row.SetValue(codeslist[i].ToString(), 3);
                    int isInList = 0;
                    i++;
                    foreach (DataGridViewRow code in searchData.Rows)
                    {
                        if (code.Cells[0].Value.ToString() == row[0])
                        {
                            isInList = 1; // Do Nothing
                        }
                    }
                    if (isInList == 0)
                    {
                        searchData.Rows.Add(row);
                    }
                }
            }
            catch
            {

            }
        }

        public void updateChatUsers()
        {
            char[] delimit = new char[] { '_' };
            try
            {
                foreach (string peer in server.foundPeers)
                {
                    string[] row2 = { "", "" };
                    int i = 0;
                    foreach (string col in peer.Split(delimit))
                    {
                        row2.SetValue(col, i);
                        i++;
                    }

                    int isInList = 0;
                    foreach (DataGridViewRow ip in knownPeersChatData.Rows)
                    {
                        if (ip.Cells[0].Value.ToString() == row2[0])
                        {
                            isInList = 1; // Do Nothing
                        }
                    }
                    if (isInList == 0)
                    {
                        knownPeersChatData.Rows.Add(row2);
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("updateChatUsersOopsException: " + e);
            }
        }

        public void updateFoundPeers()
        {
            char[] delimit = new char[] { '_' };
            try
            {
                foreach (string peer in server.foundPeers)
                {
                    string[] row = { "", "", "" };
                    int i = 0;
                    foreach (string col in peer.Split(delimit))
                    {
                        row.SetValue(col, i);
                        i++;
                    }
                    row.SetValue("0", 2);
                    //Console.WriteLine(row[0]);
                    int isInList = 0;
                    foreach (DataGridViewRow ip in peersData.Rows)
                    {
                        if (ip.Cells[0].Value.ToString() == row[0])
                        {
                            isInList = 1; // Do Nothing
                        }
                    }
                    if (isInList == 0)
                    {
                        Console.WriteLine("should be adding");
                        peersData.Rows.Add(row);
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("updateFoundPeersOopsException: " + e);
            }
        }

        public void updateTransfers(Transfer transfer)
        {
            if (transfer.type == "download")
            {
                //add data to downloading datagrid
            }
            else if (transfer.type == "upload") 
            {
                //add data to uploading datagrid
            }
        }

        public void updateStats()
        {
            pingStat.Text = stats.numPing + "";
            pongStat.Text = stats.numPong + "";
            queryStat.Text = stats.numQuery + "";
            queryHitStat.Text = stats.numQueryHit + "";
            pushStat.Text = stats.numPush + "";
            bytesdlStat.Text = stats.numBytesReceived + "";
            bytesulStat.Text = stats.numBytesSent + "";
            filesulStat.Text = FileSender.completed + "";
            filesdlStat.Text = FileReceiver.completed + "";
            statusLabel.Text = downloadData.RowCount + " Downloads / " + uploadData.RowCount + " Uploads - Sharing " + sharedData.RowCount + " files with " + stats.numPeers + " peers.";
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

            else if (sender == searchData)
            {
                DataGridViewCellCollection tempRow = searchData.CurrentRow.Cells;
                if (tempRow[0] != null && tempRow[2] != null)
                {

                    senderIP = tempRow[2].Value.ToString().Split(':')[0];
                    string temp = tempRow[2].Value.ToString().Split(':')[1];
                    try
                    {
                        senderPort = int.Parse(temp);
                    }
                    catch { }
                    senderFilename = tempRow[0].Value.ToString();
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
            if (sender == chatSendButton)
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
                FileInfo info = new FileInfo(shareFileBox.Text);
                long filesize = info.Length;
                string filesizeConverted = "";
                if (shareCategoryCombo.SelectedIndex == -1)
                {
                    shareCategoryCombo.SelectedIndex = 0;
                }
                if (filesize > 1024 && filesize < 1048576)
                {
                    filesize = filesize / 1024;
                    filesizeConverted = filesize.ToString() + " KB";
                }
                else if (filesize > 1048576 && filesize < 1073741824)
                {
                    filesize = filesize / 1048576;
                    filesizeConverted = filesize.ToString() + " MB";
                }
                else if (filesize > 1073741824)
                {
                    filesize = filesize / 1073741824;
                    filesizeConverted = filesize.ToString() + " GB";
                }
                else
                {
                    filesizeConverted = filesize.ToString() + " bytes"; 
                }
                file = category[shareCategoryCombo.SelectedIndex] + "*" + shareTitleBox.Text + "*" + shareFileBox.Text + "|" + filesizeConverted;
                
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
                            filePath = filePath.Split('|')[0];
                        }
                        fileName = filePath.Split('\\')[filePath.Split('\\').Length-1];
                        i++;
                    }
                    row.SetValue(fileName, 0);
                    row.SetValue(sharedCategory, 1);
                    row.SetValue(title, 2);
                    
                    row.SetValue(filesizeConverted, 3);
                    row.SetValue("?", 4);
                    sharedData.Rows.Add(row);
                    
                }
                catch (NullReferenceException) { }
            }
            else if (sender == searchButton)
            {
                if(searchCategoryCombo.SelectedIndex == -1) {
                    searchCategoryCombo.SelectedIndex = 0;
                }
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
            else if (sender == downloadButton)
            {
                if (senderIP == null)
                {
                    DataGridViewCellCollection tempRow = searchData.CurrentRow.Cells;
                    if (tempRow[0] != null && tempRow[2] != null)
                    {

                        senderIP = tempRow[2].Value.ToString().Split(':')[0];
                        string temp = tempRow[2].Value.ToString().Split(':')[1];
                        try
                        {
                            senderPort = int.Parse(temp);
                        }
                        catch { }
                        senderFilename = tempRow[0].Value.ToString();
                    }
                    transferFilesize = tempRow[1].Value.ToString();
                }
                server.CreatePush(senderIP, senderPort, senderFilename);
                transferIP = senderIP;
                transferPort = senderPort.ToString();
                transferFilename = senderFilename;
            }
            else if (sender == addPeerButton)
            {
                bool noException = true;
                string ip = ipBox.Text;
                int port = 12345;
                int successCode = 0;

                try
                {
                    successCode = server.CreatePing(ip, port);
                    if (successCode == 0)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to find a peer at " + ip + ":" + port);
                    noException = false;
                }
                if (noException)
                {
                    server.AddKnownPeer(ip, port);
                    ipBox.Text = "";
                    //might need to manually update knownPeersData
                }
            }
            else if (sender == movePeerButton)
            {
                if (movePeerIP == null)
                {
                    DataGridViewCellCollection tempRow = peersData.CurrentRow.Cells;
                    if (tempRow[0] != null && tempRow[1] != null)
                    {

                        movePeerIP = tempRow[0].Value.ToString();
                        string temp = tempRow[1].Value.ToString();
                        try
                        {
                            movePeerPort = int.Parse(temp);
                        }
                        catch { }
                    }
                }
                server.AddKnownPeer(movePeerIP, movePeerPort);
                peersData.Rows.Remove(peersData.CurrentRow);
                
                
                //might need to manually update knownPeersData
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
                if (stats.numPing > 0 || stats.numQuery > 0) //CHANGE THIS TO PONGS || QUERY @ DEMO
                {
                    tabControl.Enabled = true;
                    connectToolStripMenuItem.Enabled = false;
                    //disconnectToolStripMenuItem.Enabled = true;
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