namespace Techtella
{
    partial class Form1
    {
        //Statistics stats = new Statistics();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTechtellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.startTab = new System.Windows.Forms.TabPage();
            this.startBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectionsTab = new System.Windows.Forms.TabPage();
            this.peersRefreshButton = new System.Windows.Forms.Button();
            this.movePeerButton = new System.Windows.Forms.Button();
            this.addPeerButton = new System.Windows.Forms.Button();
            this.addPeerLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.knownPeersLabel = new System.Windows.Forms.Label();
            this.peersLabel = new System.Windows.Forms.Label();
            this.peersData = new System.Windows.Forms.DataGridView();
            this.ipColumnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portColumnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileColumnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knownPeersData = new System.Windows.Forms.DataGridView();
            this.ipColumnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portColumnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFilesColumnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfersTab = new System.Windows.Forms.TabPage();
            this.downloadsLabel = new System.Windows.Forms.Label();
            this.uploadsLabel = new System.Windows.Forms.Label();
            this.uploadData = new System.Windows.Forms.DataGridView();
            this.ulFileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulProgressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulUploadedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulSpeedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulIPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulPortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadData = new System.Windows.Forms.DataGridView();
            this.dlFilenameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlStatusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlProgressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlDownloadedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlspeedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlIPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlPortCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchData = new System.Windows.Forms.DataGridView();
            this.searchFileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchIPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchHopCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchCategoryCombo = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.searchTitleLabel = new System.Windows.Forms.Label();
            this.searchFileLabel = new System.Windows.Forms.Label();
            this.searchTitleBox = new System.Windows.Forms.TextBox();
            this.searchFileNameBox = new System.Windows.Forms.TextBox();
            this.sharedTab = new System.Windows.Forms.TabPage();
            this.removeButton = new System.Windows.Forms.Button();
            this.shareCategoryCombo = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.shareTitleBox = new System.Windows.Forms.TextBox();
            this.shareFileBox = new System.Windows.Forms.TextBox();
            this.shareSharedLabel = new System.Windows.Forms.Label();
            this.shareFileLabel = new System.Windows.Forms.Label();
            this.shareTitleLabel = new System.Windows.Forms.Label();
            this.shareCategoryLabel = new System.Windows.Forms.Label();
            this.sharedData = new System.Windows.Forms.DataGridView();
            this.sharedFileNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharedCategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharedTitleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharedFileSizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sharedIdentifierCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.refreshStatsButton = new System.Windows.Forms.Button();
            this.statsPeersLabel = new System.Windows.Forms.Label();
            this.statsSharedData = new System.Windows.Forms.DataGridView();
            this.sharedStatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlStatsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadersBox = new System.Windows.Forms.ListBox();
            this.transferGroup = new System.Windows.Forms.GroupBox();
            this.bytesdlStat = new System.Windows.Forms.Label();
            this.filesulLabel = new System.Windows.Forms.Label();
            this.bytesulStat = new System.Windows.Forms.Label();
            this.filesdlLabel = new System.Windows.Forms.Label();
            this.filesdlStat = new System.Windows.Forms.Label();
            this.bytesulLabel = new System.Windows.Forms.Label();
            this.filesulStat = new System.Windows.Forms.Label();
            this.bytesdlLabel = new System.Windows.Forms.Label();
            this.messagesGroup = new System.Windows.Forms.GroupBox();
            this.pingLabel = new System.Windows.Forms.Label();
            this.pongLabel = new System.Windows.Forms.Label();
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryHitLabel = new System.Windows.Forms.Label();
            this.pushStat = new System.Windows.Forms.Label();
            this.pushLabel = new System.Windows.Forms.Label();
            this.queryHitStat = new System.Windows.Forms.Label();
            this.pingStat = new System.Windows.Forms.Label();
            this.queryStat = new System.Windows.Forms.Label();
            this.pongStat = new System.Windows.Forms.Label();
            this.downloadersLabel = new System.Windows.Forms.Label();
            this.chatTab = new System.Windows.Forms.TabPage();
            this.knownPeersChatData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatSendButton = new System.Windows.Forms.Button();
            this.chatInputBox = new System.Windows.Forms.TextBox();
            this.chatOutputBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.startTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.connectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peersData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knownPeersData)).BeginInit();
            this.transfersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadData)).BeginInit();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).BeginInit();
            this.sharedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharedData)).BeginInit();
            this.statsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsSharedData)).BeginInit();
            this.transferGroup.SuspendLayout();
            this.messagesGroup.SuspendLayout();
            this.chatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knownPeersChatData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1141, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem1.Text = "Connection";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.settingsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTechtellaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTechtellaToolStripMenuItem
            // 
            this.aboutTechtellaToolStripMenuItem.Name = "aboutTechtellaToolStripMenuItem";
            this.aboutTechtellaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutTechtellaToolStripMenuItem.Text = "About Techtella";
            this.aboutTechtellaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1141, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(164, 18);
            this.statusLabel.Text = "0 Downloads, 0 Uploads";
            this.statusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // statusLabel2
            // 
            this.statusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(196, 18);
            this.statusLabel2.Text = "-  Sharing 0 files with 0 peers";
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Controls.Add(this.startTab);
            this.tabControl.Controls.Add(this.connectionsTab);
            this.tabControl.Controls.Add(this.transfersTab);
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Controls.Add(this.sharedTab);
            this.tabControl.Controls.Add(this.statsTab);
            this.tabControl.Controls.Add(this.chatTab);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(0, 33);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1141, 652);
            this.tabControl.TabIndex = 2;
            this.tabControl.Tag = "";
            // 
            // startTab
            // 
            this.startTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.startTab.Controls.Add(this.startBox);
            this.startTab.Controls.Add(this.pictureBox1);
            this.startTab.Location = new System.Drawing.Point(4, 25);
            this.startTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTab.Name = "startTab";
            this.startTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTab.Size = new System.Drawing.Size(1133, 623);
            this.startTab.TabIndex = 0;
            this.startTab.Text = "Start";
            this.startTab.UseVisualStyleBackColor = true;
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.startBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBox.ForeColor = System.Drawing.Color.Black;
            this.startBox.Location = new System.Drawing.Point(8, 138);
            this.startBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startBox.Multiline = true;
            this.startBox.Name = "startBox";
            this.startBox.ReadOnly = true;
            this.startBox.Size = new System.Drawing.Size(666, 443);
            this.startBox.TabIndex = 1;
            this.startBox.Text = resources.GetString("startBox.Text");
            this.startBox.TextChanged += new System.EventHandler(this.startBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Techtella.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // connectionsTab
            // 
            this.connectionsTab.Controls.Add(this.peersRefreshButton);
            this.connectionsTab.Controls.Add(this.movePeerButton);
            this.connectionsTab.Controls.Add(this.addPeerButton);
            this.connectionsTab.Controls.Add(this.addPeerLabel);
            this.connectionsTab.Controls.Add(this.portLabel);
            this.connectionsTab.Controls.Add(this.ipLabel);
            this.connectionsTab.Controls.Add(this.portBox);
            this.connectionsTab.Controls.Add(this.ipBox);
            this.connectionsTab.Controls.Add(this.knownPeersLabel);
            this.connectionsTab.Controls.Add(this.peersLabel);
            this.connectionsTab.Controls.Add(this.peersData);
            this.connectionsTab.Controls.Add(this.knownPeersData);
            this.connectionsTab.Location = new System.Drawing.Point(4, 25);
            this.connectionsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionsTab.Name = "connectionsTab";
            this.connectionsTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionsTab.Size = new System.Drawing.Size(1133, 623);
            this.connectionsTab.TabIndex = 1;
            this.connectionsTab.Text = "Connections";
            this.connectionsTab.UseVisualStyleBackColor = true;
            // 
            // peersRefreshButton
            // 
            this.peersRefreshButton.Location = new System.Drawing.Point(797, 433);
            this.peersRefreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peersRefreshButton.Name = "peersRefreshButton";
            this.peersRefreshButton.Size = new System.Drawing.Size(120, 28);
            this.peersRefreshButton.TabIndex = 11;
            this.peersRefreshButton.Text = "Refresh";
            this.peersRefreshButton.UseVisualStyleBackColor = true;
            this.peersRefreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // movePeerButton
            // 
            this.movePeerButton.Location = new System.Drawing.Point(797, 396);
            this.movePeerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movePeerButton.Name = "movePeerButton";
            this.movePeerButton.Size = new System.Drawing.Size(120, 28);
            this.movePeerButton.TabIndex = 10;
            this.movePeerButton.Text = "Move to Known";
            this.movePeerButton.UseVisualStyleBackColor = true;
            this.movePeerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addPeerButton
            // 
            this.addPeerButton.Location = new System.Drawing.Point(120, 484);
            this.addPeerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPeerButton.Name = "addPeerButton";
            this.addPeerButton.Size = new System.Drawing.Size(100, 28);
            this.addPeerButton.TabIndex = 9;
            this.addPeerButton.Text = "Add Peer";
            this.addPeerButton.UseVisualStyleBackColor = true;
            // 
            // addPeerLabel
            // 
            this.addPeerLabel.AutoSize = true;
            this.addPeerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPeerLabel.Location = new System.Drawing.Point(31, 396);
            this.addPeerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPeerLabel.Name = "addPeerLabel";
            this.addPeerLabel.Size = new System.Drawing.Size(139, 17);
            this.addPeerLabel.TabIndex = 8;
            this.addPeerLabel.Text = "Add a known Peer";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(73, 455);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 17);
            this.portLabel.TabIndex = 7;
            this.portLabel.Text = "Port:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(31, 423);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(80, 17);
            this.ipLabel.TabIndex = 6;
            this.ipLabel.Text = "IP Address:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(120, 452);
            this.portBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.portBox.MaxLength = 5;
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(132, 22);
            this.portBox.TabIndex = 5;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(120, 420);
            this.ipBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipBox.MaxLength = 15;
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(132, 22);
            this.ipBox.TabIndex = 4;
            // 
            // knownPeersLabel
            // 
            this.knownPeersLabel.AutoSize = true;
            this.knownPeersLabel.Location = new System.Drawing.Point(0, 20);
            this.knownPeersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.knownPeersLabel.Name = "knownPeersLabel";
            this.knownPeersLabel.Size = new System.Drawing.Size(216, 17);
            this.knownPeersLabel.TabIndex = 3;
            this.knownPeersLabel.Text = "Known Peers (those 1 hop away)";
            // 
            // peersLabel
            // 
            this.peersLabel.AutoSize = true;
            this.peersLabel.Location = new System.Drawing.Point(596, 20);
            this.peersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.peersLabel.Name = "peersLabel";
            this.peersLabel.Size = new System.Drawing.Size(232, 17);
            this.peersLabel.TabIndex = 2;
            this.peersLabel.Text = "Peers (found through known peers)";
            // 
            // peersData
            // 
            this.peersData.AllowUserToAddRows = false;
            this.peersData.AllowUserToDeleteRows = false;
            this.peersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.peersData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.peersData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.peersData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.peersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipColumnB,
            this.portColumnB,
            this.fileColumnB});
            this.peersData.Location = new System.Drawing.Point(600, 39);
            this.peersData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peersData.Name = "peersData";
            this.peersData.ReadOnly = true;
            this.peersData.RowHeadersVisible = false;
            this.peersData.RowTemplate.Height = 24;
            this.peersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.peersData.Size = new System.Drawing.Size(520, 342);
            this.peersData.TabIndex = 1;
            // 
            // ipColumnB
            // 
            this.ipColumnB.HeaderText = "IP Address";
            this.ipColumnB.Name = "ipColumnB";
            this.ipColumnB.ReadOnly = true;
            // 
            // portColumnB
            // 
            this.portColumnB.HeaderText = "Port";
            this.portColumnB.Name = "portColumnB";
            this.portColumnB.ReadOnly = true;
            // 
            // fileColumnB
            // 
            this.fileColumnB.HeaderText = "Files Available";
            this.fileColumnB.Name = "fileColumnB";
            this.fileColumnB.ReadOnly = true;
            // 
            // knownPeersData
            // 
            this.knownPeersData.AllowUserToAddRows = false;
            this.knownPeersData.AllowUserToDeleteRows = false;
            this.knownPeersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.knownPeersData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.knownPeersData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.knownPeersData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.knownPeersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knownPeersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipColumnA,
            this.portColumnA,
            this.numFilesColumnA});
            this.knownPeersData.Location = new System.Drawing.Point(4, 39);
            this.knownPeersData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.knownPeersData.Name = "knownPeersData";
            this.knownPeersData.ReadOnly = true;
            this.knownPeersData.RowHeadersVisible = false;
            this.knownPeersData.RowTemplate.Height = 24;
            this.knownPeersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.knownPeersData.Size = new System.Drawing.Size(523, 342);
            this.knownPeersData.TabIndex = 0;
            this.knownPeersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ipColumnA
            // 
            this.ipColumnA.HeaderText = "IP Address";
            this.ipColumnA.Name = "ipColumnA";
            this.ipColumnA.ReadOnly = true;
            // 
            // portColumnA
            // 
            this.portColumnA.HeaderText = "Port";
            this.portColumnA.Name = "portColumnA";
            this.portColumnA.ReadOnly = true;
            // 
            // numFilesColumnA
            // 
            this.numFilesColumnA.HeaderText = "Files Available";
            this.numFilesColumnA.Name = "numFilesColumnA";
            this.numFilesColumnA.ReadOnly = true;
            // 
            // transfersTab
            // 
            this.transfersTab.Controls.Add(this.downloadsLabel);
            this.transfersTab.Controls.Add(this.uploadsLabel);
            this.transfersTab.Controls.Add(this.uploadData);
            this.transfersTab.Controls.Add(this.downloadData);
            this.transfersTab.Location = new System.Drawing.Point(4, 25);
            this.transfersTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transfersTab.Name = "transfersTab";
            this.transfersTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transfersTab.Size = new System.Drawing.Size(1133, 623);
            this.transfersTab.TabIndex = 2;
            this.transfersTab.Text = "Transfers";
            this.transfersTab.UseVisualStyleBackColor = true;
            // 
            // downloadsLabel
            // 
            this.downloadsLabel.AutoSize = true;
            this.downloadsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadsLabel.Location = new System.Drawing.Point(4, 11);
            this.downloadsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadsLabel.Name = "downloadsLabel";
            this.downloadsLabel.Size = new System.Drawing.Size(86, 17);
            this.downloadsLabel.TabIndex = 3;
            this.downloadsLabel.Text = "Downloads";
            // 
            // uploadsLabel
            // 
            this.uploadsLabel.AutoSize = true;
            this.uploadsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadsLabel.Location = new System.Drawing.Point(4, 319);
            this.uploadsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uploadsLabel.Name = "uploadsLabel";
            this.uploadsLabel.Size = new System.Drawing.Size(67, 17);
            this.uploadsLabel.TabIndex = 2;
            this.uploadsLabel.Text = "Uploads";
            // 
            // uploadData
            // 
            this.uploadData.AllowUserToAddRows = false;
            this.uploadData.AllowUserToDeleteRows = false;
            this.uploadData.AllowUserToOrderColumns = true;
            this.uploadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uploadData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.uploadData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.uploadData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.uploadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uploadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ulFileNameCol,
            this.ulStatusCol,
            this.ulProgressCol,
            this.ulSizeCol,
            this.ulUploadedCol,
            this.ulSpeedCol,
            this.ulIPCol,
            this.ulPortCol});
            this.uploadData.Location = new System.Drawing.Point(0, 338);
            this.uploadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadData.Name = "uploadData";
            this.uploadData.ReadOnly = true;
            this.uploadData.RowHeadersVisible = false;
            this.uploadData.RowTemplate.Height = 24;
            this.uploadData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uploadData.Size = new System.Drawing.Size(1131, 274);
            this.uploadData.TabIndex = 1;
            // 
            // ulFileNameCol
            // 
            this.ulFileNameCol.HeaderText = "File Name";
            this.ulFileNameCol.Name = "ulFileNameCol";
            this.ulFileNameCol.ReadOnly = true;
            // 
            // ulStatusCol
            // 
            this.ulStatusCol.HeaderText = "Status";
            this.ulStatusCol.Name = "ulStatusCol";
            this.ulStatusCol.ReadOnly = true;
            // 
            // ulProgressCol
            // 
            this.ulProgressCol.HeaderText = "Progress";
            this.ulProgressCol.Name = "ulProgressCol";
            this.ulProgressCol.ReadOnly = true;
            // 
            // ulSizeCol
            // 
            this.ulSizeCol.HeaderText = "File Size";
            this.ulSizeCol.Name = "ulSizeCol";
            this.ulSizeCol.ReadOnly = true;
            // 
            // ulUploadedCol
            // 
            this.ulUploadedCol.HeaderText = "Uploaded";
            this.ulUploadedCol.Name = "ulUploadedCol";
            this.ulUploadedCol.ReadOnly = true;
            // 
            // ulSpeedCol
            // 
            this.ulSpeedCol.HeaderText = "KB/s";
            this.ulSpeedCol.Name = "ulSpeedCol";
            this.ulSpeedCol.ReadOnly = true;
            // 
            // ulIPCol
            // 
            this.ulIPCol.HeaderText = "IP";
            this.ulIPCol.Name = "ulIPCol";
            this.ulIPCol.ReadOnly = true;
            // 
            // ulPortCol
            // 
            this.ulPortCol.HeaderText = "Port";
            this.ulPortCol.Name = "ulPortCol";
            this.ulPortCol.ReadOnly = true;
            // 
            // downloadData
            // 
            this.downloadData.AllowUserToAddRows = false;
            this.downloadData.AllowUserToDeleteRows = false;
            this.downloadData.AllowUserToOrderColumns = true;
            this.downloadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.downloadData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.downloadData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.downloadData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.downloadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.downloadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dlFilenameCol,
            this.dlStatusCol,
            this.dlProgressCol,
            this.dlSizeCol,
            this.dlDownloadedCol,
            this.dlspeedCol,
            this.dlIPCol,
            this.dlPortCol});
            this.downloadData.Location = new System.Drawing.Point(0, 31);
            this.downloadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downloadData.Name = "downloadData";
            this.downloadData.ReadOnly = true;
            this.downloadData.RowHeadersVisible = false;
            this.downloadData.RowTemplate.Height = 24;
            this.downloadData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.downloadData.Size = new System.Drawing.Size(1131, 274);
            this.downloadData.TabIndex = 0;
            // 
            // dlFilenameCol
            // 
            this.dlFilenameCol.HeaderText = "File Name";
            this.dlFilenameCol.Name = "dlFilenameCol";
            this.dlFilenameCol.ReadOnly = true;
            // 
            // dlStatusCol
            // 
            this.dlStatusCol.HeaderText = "Status";
            this.dlStatusCol.Name = "dlStatusCol";
            this.dlStatusCol.ReadOnly = true;
            // 
            // dlProgressCol
            // 
            this.dlProgressCol.HeaderText = "Progress";
            this.dlProgressCol.Name = "dlProgressCol";
            this.dlProgressCol.ReadOnly = true;
            // 
            // dlSizeCol
            // 
            this.dlSizeCol.HeaderText = "File Size";
            this.dlSizeCol.Name = "dlSizeCol";
            this.dlSizeCol.ReadOnly = true;
            // 
            // dlDownloadedCol
            // 
            this.dlDownloadedCol.HeaderText = "Downloaded";
            this.dlDownloadedCol.Name = "dlDownloadedCol";
            this.dlDownloadedCol.ReadOnly = true;
            // 
            // dlspeedCol
            // 
            this.dlspeedCol.HeaderText = "KB/s";
            this.dlspeedCol.Name = "dlspeedCol";
            this.dlspeedCol.ReadOnly = true;
            // 
            // dlIPCol
            // 
            this.dlIPCol.HeaderText = "IP";
            this.dlIPCol.Name = "dlIPCol";
            this.dlIPCol.ReadOnly = true;
            // 
            // dlPortCol
            // 
            this.dlPortCol.HeaderText = "Port";
            this.dlPortCol.Name = "dlPortCol";
            this.dlPortCol.ReadOnly = true;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchData);
            this.searchTab.Controls.Add(this.searchButton);
            this.searchTab.Controls.Add(this.searchCategoryCombo);
            this.searchTab.Controls.Add(this.categoryLabel);
            this.searchTab.Controls.Add(this.searchTitleLabel);
            this.searchTab.Controls.Add(this.searchFileLabel);
            this.searchTab.Controls.Add(this.searchTitleBox);
            this.searchTab.Controls.Add(this.searchFileNameBox);
            this.searchTab.Location = new System.Drawing.Point(4, 25);
            this.searchTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(1133, 623);
            this.searchTab.TabIndex = 3;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchData
            // 
            this.searchData.AllowUserToAddRows = false;
            this.searchData.AllowUserToDeleteRows = false;
            this.searchData.AllowUserToOrderColumns = true;
            this.searchData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.searchData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.searchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchFileNameCol,
            this.searchSizeCol,
            this.searchIPCol,
            this.searchHopCol});
            this.searchData.Location = new System.Drawing.Point(0, 55);
            this.searchData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchData.Name = "searchData";
            this.searchData.ReadOnly = true;
            this.searchData.RowHeadersVisible = false;
            this.searchData.RowTemplate.Height = 24;
            this.searchData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchData.Size = new System.Drawing.Size(1131, 565);
            this.searchData.TabIndex = 7;
            // 
            // searchFileNameCol
            // 
            this.searchFileNameCol.HeaderText = "File Name";
            this.searchFileNameCol.Name = "searchFileNameCol";
            this.searchFileNameCol.ReadOnly = true;
            // 
            // searchSizeCol
            // 
            this.searchSizeCol.HeaderText = "File Size";
            this.searchSizeCol.Name = "searchSizeCol";
            this.searchSizeCol.ReadOnly = true;
            // 
            // searchIPCol
            // 
            this.searchIPCol.HeaderText = "IP Address";
            this.searchIPCol.Name = "searchIPCol";
            this.searchIPCol.ReadOnly = true;
            // 
            // searchHopCol
            // 
            this.searchHopCol.HeaderText = "Hop Count";
            this.searchHopCol.Name = "searchHopCol";
            this.searchHopCol.ReadOnly = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(911, 12);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchCategoryCombo
            // 
            this.searchCategoryCombo.FormattingEnabled = true;
            this.searchCategoryCombo.Items.AddRange(new object[] {
            "ANY",
            "AUDIO",
            "VIDEO",
            "DATA",
            "TEXT",
            "IMAGE"});
            this.searchCategoryCombo.Location = new System.Drawing.Point(649, 12);
            this.searchCategoryCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchCategoryCombo.Name = "searchCategoryCombo";
            this.searchCategoryCombo.Size = new System.Drawing.Size(160, 24);
            this.searchCategoryCombo.TabIndex = 5;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(572, 16);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 17);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category:";
            // 
            // searchTitleLabel
            // 
            this.searchTitleLabel.AutoSize = true;
            this.searchTitleLabel.Location = new System.Drawing.Point(283, 16);
            this.searchTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchTitleLabel.Name = "searchTitleLabel";
            this.searchTitleLabel.Size = new System.Drawing.Size(39, 17);
            this.searchTitleLabel.TabIndex = 3;
            this.searchTitleLabel.Text = "Title:";
            // 
            // searchFileLabel
            // 
            this.searchFileLabel.AutoSize = true;
            this.searchFileLabel.Location = new System.Drawing.Point(19, 16);
            this.searchFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchFileLabel.Name = "searchFileLabel";
            this.searchFileLabel.Size = new System.Drawing.Size(75, 17);
            this.searchFileLabel.TabIndex = 2;
            this.searchFileLabel.Text = "File Name:";
            // 
            // searchTitleBox
            // 
            this.searchTitleBox.Location = new System.Drawing.Point(331, 12);
            this.searchTitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTitleBox.Name = "searchTitleBox";
            this.searchTitleBox.Size = new System.Drawing.Size(216, 22);
            this.searchTitleBox.TabIndex = 1;
            // 
            // searchFileNameBox
            // 
            this.searchFileNameBox.Location = new System.Drawing.Point(103, 12);
            this.searchFileNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchFileNameBox.Name = "searchFileNameBox";
            this.searchFileNameBox.Size = new System.Drawing.Size(157, 22);
            this.searchFileNameBox.TabIndex = 0;
            // 
            // sharedTab
            // 
            this.sharedTab.Controls.Add(this.removeButton);
            this.sharedTab.Controls.Add(this.shareCategoryCombo);
            this.sharedTab.Controls.Add(this.browseButton);
            this.sharedTab.Controls.Add(this.button1);
            this.sharedTab.Controls.Add(this.shareTitleBox);
            this.sharedTab.Controls.Add(this.shareFileBox);
            this.sharedTab.Controls.Add(this.shareSharedLabel);
            this.sharedTab.Controls.Add(this.shareFileLabel);
            this.sharedTab.Controls.Add(this.shareTitleLabel);
            this.sharedTab.Controls.Add(this.shareCategoryLabel);
            this.sharedTab.Controls.Add(this.sharedData);
            this.sharedTab.Location = new System.Drawing.Point(4, 25);
            this.sharedTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sharedTab.Name = "sharedTab";
            this.sharedTab.Size = new System.Drawing.Size(1133, 623);
            this.sharedTab.TabIndex = 4;
            this.sharedTab.Text = "Shared Files";
            this.sharedTab.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(11, 588);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(136, 28);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // shareCategoryCombo
            // 
            this.shareCategoryCombo.FormattingEnabled = true;
            this.shareCategoryCombo.Items.AddRange(new object[] {
            "ANY",
            "AUDIO",
            "VIDEO",
            "DATA",
            "TEXT",
            "IMAGE"});
            this.shareCategoryCombo.Location = new System.Drawing.Point(81, 9);
            this.shareCategoryCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shareCategoryCombo.Name = "shareCategoryCombo";
            this.shareCategoryCombo.Size = new System.Drawing.Size(160, 24);
            this.shareCategoryCombo.TabIndex = 10;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(989, 6);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 28);
            this.browseButton.TabIndex = 9;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add to Shared Files";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // shareTitleBox
            // 
            this.shareTitleBox.Location = new System.Drawing.Point(317, 9);
            this.shareTitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shareTitleBox.Name = "shareTitleBox";
            this.shareTitleBox.Size = new System.Drawing.Size(273, 22);
            this.shareTitleBox.TabIndex = 7;
            // 
            // shareFileBox
            // 
            this.shareFileBox.Location = new System.Drawing.Point(656, 9);
            this.shareFileBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shareFileBox.Name = "shareFileBox";
            this.shareFileBox.Size = new System.Drawing.Size(308, 22);
            this.shareFileBox.TabIndex = 6;
            // 
            // shareSharedLabel
            // 
            this.shareSharedLabel.AutoSize = true;
            this.shareSharedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareSharedLabel.Location = new System.Drawing.Point(4, 89);
            this.shareSharedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shareSharedLabel.Name = "shareSharedLabel";
            this.shareSharedLabel.Size = new System.Drawing.Size(99, 17);
            this.shareSharedLabel.TabIndex = 4;
            this.shareSharedLabel.Text = "Shared Files";
            // 
            // shareFileLabel
            // 
            this.shareFileLabel.AutoSize = true;
            this.shareFileLabel.Location = new System.Drawing.Point(613, 12);
            this.shareFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shareFileLabel.Name = "shareFileLabel";
            this.shareFileLabel.Size = new System.Drawing.Size(34, 17);
            this.shareFileLabel.TabIndex = 3;
            this.shareFileLabel.Text = "File:";
            // 
            // shareTitleLabel
            // 
            this.shareTitleLabel.AutoSize = true;
            this.shareTitleLabel.Location = new System.Drawing.Point(269, 12);
            this.shareTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shareTitleLabel.Name = "shareTitleLabel";
            this.shareTitleLabel.Size = new System.Drawing.Size(39, 17);
            this.shareTitleLabel.TabIndex = 2;
            this.shareTitleLabel.Text = "Title:";
            // 
            // shareCategoryLabel
            // 
            this.shareCategoryLabel.AutoSize = true;
            this.shareCategoryLabel.Location = new System.Drawing.Point(4, 12);
            this.shareCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shareCategoryLabel.Name = "shareCategoryLabel";
            this.shareCategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.shareCategoryLabel.TabIndex = 1;
            this.shareCategoryLabel.Text = "Category:";
            // 
            // sharedData
            // 
            this.sharedData.AllowUserToAddRows = false;
            this.sharedData.AllowUserToDeleteRows = false;
            this.sharedData.AllowUserToOrderColumns = true;
            this.sharedData.AllowUserToResizeRows = false;
            this.sharedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sharedData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.sharedData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.sharedData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sharedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sharedData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sharedFileNameCol,
            this.sharedCategoryCol,
            this.sharedTitleCol,
            this.sharedFileSizeCol,
            this.sharedIdentifierCol});
            this.sharedData.Location = new System.Drawing.Point(0, 108);
            this.sharedData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sharedData.MultiSelect = false;
            this.sharedData.Name = "sharedData";
            this.sharedData.ReadOnly = true;
            this.sharedData.RowHeadersVisible = false;
            this.sharedData.RowTemplate.Height = 24;
            this.sharedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sharedData.ShowEditingIcon = false;
            this.sharedData.Size = new System.Drawing.Size(1131, 473);
            this.sharedData.TabIndex = 0;
            // 
            // sharedFileNameCol
            // 
            this.sharedFileNameCol.HeaderText = "File Name";
            this.sharedFileNameCol.Name = "sharedFileNameCol";
            this.sharedFileNameCol.ReadOnly = true;
            // 
            // sharedCategoryCol
            // 
            this.sharedCategoryCol.HeaderText = "Category";
            this.sharedCategoryCol.Name = "sharedCategoryCol";
            this.sharedCategoryCol.ReadOnly = true;
            // 
            // sharedTitleCol
            // 
            this.sharedTitleCol.HeaderText = "Title";
            this.sharedTitleCol.Name = "sharedTitleCol";
            this.sharedTitleCol.ReadOnly = true;
            // 
            // sharedFileSizeCol
            // 
            this.sharedFileSizeCol.HeaderText = "File Size";
            this.sharedFileSizeCol.Name = "sharedFileSizeCol";
            this.sharedFileSizeCol.ReadOnly = true;
            // 
            // sharedIdentifierCol
            // 
            this.sharedIdentifierCol.HeaderText = "Identifier";
            this.sharedIdentifierCol.Name = "sharedIdentifierCol";
            this.sharedIdentifierCol.ReadOnly = true;
            // 
            // statsTab
            // 
            this.statsTab.Controls.Add(this.refreshStatsButton);
            this.statsTab.Controls.Add(this.statsPeersLabel);
            this.statsTab.Controls.Add(this.statsSharedData);
            this.statsTab.Controls.Add(this.downloadersBox);
            this.statsTab.Controls.Add(this.transferGroup);
            this.statsTab.Controls.Add(this.messagesGroup);
            this.statsTab.Controls.Add(this.downloadersLabel);
            this.statsTab.Location = new System.Drawing.Point(4, 25);
            this.statsTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsTab.Name = "statsTab";
            this.statsTab.Size = new System.Drawing.Size(1133, 623);
            this.statsTab.TabIndex = 5;
            this.statsTab.Text = "Statistics";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // refreshStatsButton
            // 
            this.refreshStatsButton.Location = new System.Drawing.Point(323, 450);
            this.refreshStatsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshStatsButton.Name = "refreshStatsButton";
            this.refreshStatsButton.Size = new System.Drawing.Size(121, 28);
            this.refreshStatsButton.TabIndex = 15;
            this.refreshStatsButton.Text = "Refresh Stats";
            this.refreshStatsButton.UseVisualStyleBackColor = true;
            this.refreshStatsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statsPeersLabel
            // 
            this.statsPeersLabel.AutoSize = true;
            this.statsPeersLabel.Location = new System.Drawing.Point(11, 457);
            this.statsPeersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statsPeersLabel.Name = "statsPeersLabel";
            this.statsPeersLabel.Size = new System.Drawing.Size(118, 17);
            this.statsPeersLabel.TabIndex = 14;
            this.statsPeersLabel.Text = "0 Peers Detected";
            // 
            // statsSharedData
            // 
            this.statsSharedData.AllowUserToAddRows = false;
            this.statsSharedData.AllowUserToDeleteRows = false;
            this.statsSharedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statsSharedData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.statsSharedData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.statsSharedData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.statsSharedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsSharedData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sharedStatsCol,
            this.dlStatsCol});
            this.statsSharedData.Location = new System.Drawing.Point(323, 178);
            this.statsSharedData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statsSharedData.Name = "statsSharedData";
            this.statsSharedData.ReadOnly = true;
            this.statsSharedData.RowTemplate.Height = 24;
            this.statsSharedData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statsSharedData.Size = new System.Drawing.Size(413, 245);
            this.statsSharedData.TabIndex = 13;
            this.statsSharedData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statsSharedData_CellContentClick);
            // 
            // sharedStatsCol
            // 
            this.sharedStatsCol.HeaderText = "Shared Files";
            this.sharedStatsCol.Name = "sharedStatsCol";
            this.sharedStatsCol.ReadOnly = true;
            // 
            // dlStatsCol
            // 
            this.dlStatsCol.HeaderText = "Times Downloaded";
            this.dlStatsCol.Name = "dlStatsCol";
            this.dlStatsCol.ReadOnly = true;
            // 
            // downloadersBox
            // 
            this.downloadersBox.FormattingEnabled = true;
            this.downloadersBox.ItemHeight = 16;
            this.downloadersBox.Location = new System.Drawing.Point(11, 178);
            this.downloadersBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downloadersBox.Name = "downloadersBox";
            this.downloadersBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.downloadersBox.Size = new System.Drawing.Size(265, 244);
            this.downloadersBox.TabIndex = 12;
            // 
            // transferGroup
            // 
            this.transferGroup.Controls.Add(this.bytesdlStat);
            this.transferGroup.Controls.Add(this.filesulLabel);
            this.transferGroup.Controls.Add(this.bytesulStat);
            this.transferGroup.Controls.Add(this.filesdlLabel);
            this.transferGroup.Controls.Add(this.filesdlStat);
            this.transferGroup.Controls.Add(this.bytesulLabel);
            this.transferGroup.Controls.Add(this.filesulStat);
            this.transferGroup.Controls.Add(this.bytesdlLabel);
            this.transferGroup.Location = new System.Drawing.Point(323, 18);
            this.transferGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transferGroup.Name = "transferGroup";
            this.transferGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transferGroup.Size = new System.Drawing.Size(267, 111);
            this.transferGroup.TabIndex = 11;
            this.transferGroup.TabStop = false;
            this.transferGroup.Text = "Transfers";
            // 
            // bytesdlStat
            // 
            this.bytesdlStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bytesdlStat.AutoSize = true;
            this.bytesdlStat.Location = new System.Drawing.Point(241, 68);
            this.bytesdlStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bytesdlStat.Name = "bytesdlStat";
            this.bytesdlStat.Size = new System.Drawing.Size(16, 17);
            this.bytesdlStat.TabIndex = 23;
            this.bytesdlStat.Text = "0";
            this.bytesdlStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // filesulLabel
            // 
            this.filesulLabel.AutoSize = true;
            this.filesulLabel.Location = new System.Drawing.Point(8, 20);
            this.filesulLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesulLabel.Name = "filesulLabel";
            this.filesulLabel.Size = new System.Drawing.Size(106, 17);
            this.filesulLabel.TabIndex = 5;
            this.filesulLabel.Text = "Files Uploaded:";
            // 
            // bytesulStat
            // 
            this.bytesulStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bytesulStat.AutoSize = true;
            this.bytesulStat.Location = new System.Drawing.Point(241, 52);
            this.bytesulStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bytesulStat.Name = "bytesulStat";
            this.bytesulStat.Size = new System.Drawing.Size(16, 17);
            this.bytesulStat.TabIndex = 22;
            this.bytesulStat.Text = "0";
            this.bytesulStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // filesdlLabel
            // 
            this.filesdlLabel.AutoSize = true;
            this.filesdlLabel.Location = new System.Drawing.Point(8, 36);
            this.filesdlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesdlLabel.Name = "filesdlLabel";
            this.filesdlLabel.Size = new System.Drawing.Size(123, 17);
            this.filesdlLabel.TabIndex = 6;
            this.filesdlLabel.Text = "Files Downloaded:";
            // 
            // filesdlStat
            // 
            this.filesdlStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesdlStat.AutoSize = true;
            this.filesdlStat.Location = new System.Drawing.Point(241, 36);
            this.filesdlStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesdlStat.Name = "filesdlStat";
            this.filesdlStat.Size = new System.Drawing.Size(16, 17);
            this.filesdlStat.TabIndex = 21;
            this.filesdlStat.Text = "0";
            this.filesdlStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bytesulLabel
            // 
            this.bytesulLabel.AutoSize = true;
            this.bytesulLabel.Location = new System.Drawing.Point(8, 52);
            this.bytesulLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bytesulLabel.Name = "bytesulLabel";
            this.bytesulLabel.Size = new System.Drawing.Size(112, 17);
            this.bytesulLabel.TabIndex = 7;
            this.bytesulLabel.Text = "Bytes Uploaded:";
            // 
            // filesulStat
            // 
            this.filesulStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesulStat.AutoSize = true;
            this.filesulStat.Location = new System.Drawing.Point(241, 20);
            this.filesulStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesulStat.Name = "filesulStat";
            this.filesulStat.Size = new System.Drawing.Size(16, 17);
            this.filesulStat.TabIndex = 20;
            this.filesulStat.Text = "0";
            this.filesulStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bytesdlLabel
            // 
            this.bytesdlLabel.AutoSize = true;
            this.bytesdlLabel.Location = new System.Drawing.Point(8, 68);
            this.bytesdlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bytesdlLabel.Name = "bytesdlLabel";
            this.bytesdlLabel.Size = new System.Drawing.Size(129, 17);
            this.bytesdlLabel.TabIndex = 8;
            this.bytesdlLabel.Text = "Bytes Downloaded:";
            // 
            // messagesGroup
            // 
            this.messagesGroup.Controls.Add(this.pingLabel);
            this.messagesGroup.Controls.Add(this.pongLabel);
            this.messagesGroup.Controls.Add(this.queryLabel);
            this.messagesGroup.Controls.Add(this.queryHitLabel);
            this.messagesGroup.Controls.Add(this.pushStat);
            this.messagesGroup.Controls.Add(this.pushLabel);
            this.messagesGroup.Controls.Add(this.queryHitStat);
            this.messagesGroup.Controls.Add(this.pingStat);
            this.messagesGroup.Controls.Add(this.queryStat);
            this.messagesGroup.Controls.Add(this.pongStat);
            this.messagesGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesGroup.Location = new System.Drawing.Point(11, 18);
            this.messagesGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messagesGroup.Name = "messagesGroup";
            this.messagesGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messagesGroup.Size = new System.Drawing.Size(267, 111);
            this.messagesGroup.TabIndex = 10;
            this.messagesGroup.TabStop = false;
            this.messagesGroup.Text = "Messages Processed";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(8, 20);
            this.pingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(45, 17);
            this.pingLabel.TabIndex = 0;
            this.pingLabel.Text = "PING:";
            // 
            // pongLabel
            // 
            this.pongLabel.AutoSize = true;
            this.pongLabel.Location = new System.Drawing.Point(8, 36);
            this.pongLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pongLabel.Name = "pongLabel";
            this.pongLabel.Size = new System.Drawing.Size(53, 17);
            this.pongLabel.TabIndex = 1;
            this.pongLabel.Text = "PONG:";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(8, 52);
            this.queryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(61, 17);
            this.queryLabel.TabIndex = 2;
            this.queryLabel.Text = "QUERY:";
            // 
            // queryHitLabel
            // 
            this.queryHitLabel.AutoSize = true;
            this.queryHitLabel.Location = new System.Drawing.Point(8, 68);
            this.queryHitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryHitLabel.Name = "queryHitLabel";
            this.queryHitLabel.Size = new System.Drawing.Size(83, 17);
            this.queryHitLabel.TabIndex = 3;
            this.queryHitLabel.Text = "QUERYHIT:";
            // 
            // pushStat
            // 
            this.pushStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pushStat.AutoSize = true;
            this.pushStat.Location = new System.Drawing.Point(241, 84);
            this.pushStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pushStat.Name = "pushStat";
            this.pushStat.Size = new System.Drawing.Size(16, 17);
            this.pushStat.TabIndex = 19;
            this.pushStat.Text = "0";
            this.pushStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pushLabel
            // 
            this.pushLabel.AutoSize = true;
            this.pushLabel.Location = new System.Drawing.Point(8, 84);
            this.pushLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pushLabel.Name = "pushLabel";
            this.pushLabel.Size = new System.Drawing.Size(50, 17);
            this.pushLabel.TabIndex = 4;
            this.pushLabel.Text = "PUSH:";
            // 
            // queryHitStat
            // 
            this.queryHitStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryHitStat.AutoSize = true;
            this.queryHitStat.Location = new System.Drawing.Point(241, 68);
            this.queryHitStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryHitStat.Name = "queryHitStat";
            this.queryHitStat.Size = new System.Drawing.Size(16, 17);
            this.queryHitStat.TabIndex = 18;
            this.queryHitStat.Text = "0";
            this.queryHitStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pingStat
            // 
            this.pingStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pingStat.AutoSize = true;
            this.pingStat.Location = new System.Drawing.Point(241, 20);
            this.pingStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pingStat.Name = "pingStat";
            this.pingStat.Size = new System.Drawing.Size(16, 17);
            this.pingStat.TabIndex = 15;
            this.pingStat.Text = "0";
            this.pingStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // queryStat
            // 
            this.queryStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.queryStat.AutoSize = true;
            this.queryStat.Location = new System.Drawing.Point(241, 52);
            this.queryStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryStat.Name = "queryStat";
            this.queryStat.Size = new System.Drawing.Size(16, 17);
            this.queryStat.TabIndex = 17;
            this.queryStat.Text = "0";
            this.queryStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pongStat
            // 
            this.pongStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pongStat.AutoSize = true;
            this.pongStat.Location = new System.Drawing.Point(241, 36);
            this.pongStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pongStat.Name = "pongStat";
            this.pongStat.Size = new System.Drawing.Size(16, 17);
            this.pongStat.TabIndex = 16;
            this.pongStat.Text = "0";
            this.pongStat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // downloadersLabel
            // 
            this.downloadersLabel.AutoSize = true;
            this.downloadersLabel.Location = new System.Drawing.Point(7, 159);
            this.downloadersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.downloadersLabel.Name = "downloadersLabel";
            this.downloadersLabel.Size = new System.Drawing.Size(94, 17);
            this.downloadersLabel.TabIndex = 9;
            this.downloadersLabel.Text = "Downloaders:";
            // 
            // chatTab
            // 
            this.chatTab.Controls.Add(this.knownPeersChatData);
            this.chatTab.Controls.Add(this.chatSendButton);
            this.chatTab.Controls.Add(this.chatInputBox);
            this.chatTab.Controls.Add(this.chatOutputBox);
            this.chatTab.Location = new System.Drawing.Point(4, 25);
            this.chatTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatTab.Name = "chatTab";
            this.chatTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatTab.Size = new System.Drawing.Size(1133, 623);
            this.chatTab.TabIndex = 6;
            this.chatTab.Text = "Chat";
            this.chatTab.UseVisualStyleBackColor = true;
            // 
            // knownPeersChatData
            // 
            this.knownPeersChatData.AllowUserToAddRows = false;
            this.knownPeersChatData.AllowUserToDeleteRows = false;
            this.knownPeersChatData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.knownPeersChatData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.knownPeersChatData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.knownPeersChatData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knownPeersChatData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.knownPeersChatData.Location = new System.Drawing.Point(845, 7);
            this.knownPeersChatData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.knownPeersChatData.MultiSelect = false;
            this.knownPeersChatData.Name = "knownPeersChatData";
            this.knownPeersChatData.ReadOnly = true;
            this.knownPeersChatData.RowHeadersVisible = false;
            this.knownPeersChatData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.knownPeersChatData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.knownPeersChatData.Size = new System.Drawing.Size(275, 606);
            this.knownPeersChatData.TabIndex = 4;
            this.knownPeersChatData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Known Peers";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Port";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // chatSendButton
            // 
            this.chatSendButton.Location = new System.Drawing.Point(737, 521);
            this.chatSendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatSendButton.Name = "chatSendButton";
            this.chatSendButton.Size = new System.Drawing.Size(100, 92);
            this.chatSendButton.TabIndex = 3;
            this.chatSendButton.Text = "Send";
            this.chatSendButton.UseVisualStyleBackColor = true;
            this.chatSendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatInputBox
            // 
            this.chatInputBox.Location = new System.Drawing.Point(4, 521);
            this.chatInputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatInputBox.Multiline = true;
            this.chatInputBox.Name = "chatInputBox";
            this.chatInputBox.Size = new System.Drawing.Size(724, 91);
            this.chatInputBox.TabIndex = 1;
            this.chatInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            // 
            // chatOutputBox
            // 
            this.chatOutputBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chatOutputBox.Location = new System.Drawing.Point(4, 7);
            this.chatOutputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chatOutputBox.MaxLength = 327676;
            this.chatOutputBox.Multiline = true;
            this.chatOutputBox.Name = "chatOutputBox";
            this.chatOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatOutputBox.Size = new System.Drawing.Size(832, 505);
            this.chatOutputBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 731);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1149, 763);
            this.MinimumSize = new System.Drawing.Size(1149, 741);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Techtella";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.startTab.ResumeLayout(false);
            this.startTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.connectionsTab.ResumeLayout(false);
            this.connectionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peersData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knownPeersData)).EndInit();
            this.transfersTab.ResumeLayout(false);
            this.transfersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadData)).EndInit();
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchData)).EndInit();
            this.sharedTab.ResumeLayout(false);
            this.sharedTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharedData)).EndInit();
            this.statsTab.ResumeLayout(false);
            this.statsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsSharedData)).EndInit();
            this.transferGroup.ResumeLayout(false);
            this.transferGroup.PerformLayout();
            this.messagesGroup.ResumeLayout(false);
            this.messagesGroup.PerformLayout();
            this.chatTab.ResumeLayout(false);
            this.chatTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knownPeersChatData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage startTab;
        private System.Windows.Forms.TabPage connectionsTab;
        private System.Windows.Forms.TabPage transfersTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage sharedTab;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTechtellaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox startBox;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.DataGridView knownPeersData;
        private System.Windows.Forms.DataGridView peersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipColumnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn portColumnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileColumnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipColumnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn portColumnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFilesColumnA;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label knownPeersLabel;
        private System.Windows.Forms.Label peersLabel;
        private System.Windows.Forms.Button movePeerButton;
        private System.Windows.Forms.Button addPeerButton;
        private System.Windows.Forms.Label addPeerLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.DataGridView downloadData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlFilenameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlStatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlProgressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlDownloadedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlspeedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlIPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlPortCol;
        private System.Windows.Forms.Label downloadsLabel;
        private System.Windows.Forms.Label uploadsLabel;
        private System.Windows.Forms.DataGridView uploadData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulFileNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulStatusCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulProgressCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulUploadedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulSpeedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulIPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulPortCol;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label searchTitleLabel;
        private System.Windows.Forms.Label searchFileLabel;
        private System.Windows.Forms.TextBox searchTitleBox;
        private System.Windows.Forms.TextBox searchFileNameBox;
        private System.Windows.Forms.DataGridView searchData;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchCategoryCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchFileNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchIPCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchHopCol;
        private System.Windows.Forms.ComboBox shareCategoryCombo;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox shareTitleBox;
        private System.Windows.Forms.TextBox shareFileBox;
        private System.Windows.Forms.Label shareSharedLabel;
        private System.Windows.Forms.Label shareFileLabel;
        private System.Windows.Forms.Label shareTitleLabel;
        private System.Windows.Forms.Label shareCategoryLabel;
        private System.Windows.Forms.DataGridView sharedData;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedFileNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedCategoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedTitleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedFileSizeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedIdentifierCol;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel2;
        private System.Windows.Forms.GroupBox transferGroup;
        private System.Windows.Forms.GroupBox messagesGroup;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label pongLabel;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Label downloadersLabel;
        private System.Windows.Forms.Label bytesdlLabel;
        private System.Windows.Forms.Label bytesulLabel;
        private System.Windows.Forms.Label filesdlLabel;
        private System.Windows.Forms.Label filesulLabel;
        private System.Windows.Forms.Label pushLabel;
        private System.Windows.Forms.Label queryHitLabel;
        private System.Windows.Forms.ListBox downloadersBox;
        private System.Windows.Forms.DataGridView statsSharedData;
        private System.Windows.Forms.Label statsPeersLabel;
        private System.Windows.Forms.Label pingStat;
        private System.Windows.Forms.Label bytesdlStat;
        private System.Windows.Forms.Label bytesulStat;
        private System.Windows.Forms.Label filesdlStat;
        private System.Windows.Forms.Label filesulStat;
        private System.Windows.Forms.Label pushStat;
        private System.Windows.Forms.Label queryHitStat;
        private System.Windows.Forms.Label queryStat;
        private System.Windows.Forms.Label pongStat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.Button peersRefreshButton;
        private System.Windows.Forms.Button refreshStatsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sharedStatsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlStatsCol;
        private System.Windows.Forms.TabPage chatTab;
        public System.Windows.Forms.TextBox chatOutputBox;
        private System.Windows.Forms.TextBox chatInputBox;
        private System.Windows.Forms.Button chatSendButton;
        private System.Windows.Forms.DataGridView knownPeersChatData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

