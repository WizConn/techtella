namespace Techtella
{
    partial class Settings
    {
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
            this.maxPeersLabel = new System.Windows.Forms.Label();
            this.peersUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsPortBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.settingsCancelButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.directoryBrowseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.peersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // maxPeersLabel
            // 
            this.maxPeersLabel.AutoSize = true;
            this.maxPeersLabel.Location = new System.Drawing.Point(12, 9);
            this.maxPeersLabel.Name = "maxPeersLabel";
            this.maxPeersLabel.Size = new System.Drawing.Size(136, 13);
            this.maxPeersLabel.TabIndex = 0;
            this.maxPeersLabel.Text = "Maximum Number of Peers:";
            // 
            // peersUpDown
            // 
            this.peersUpDown.Location = new System.Drawing.Point(154, 7);
            this.peersUpDown.Name = "peersUpDown";
            this.peersUpDown.Size = new System.Drawing.Size(100, 20);
            this.peersUpDown.TabIndex = 1;
            this.peersUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.peersUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Transfer Port:";
            // 
            // settingsPortBox
            // 
            this.settingsPortBox.Location = new System.Drawing.Point(154, 33);
            this.settingsPortBox.Name = "settingsPortBox";
            this.settingsPortBox.Size = new System.Drawing.Size(100, 20);
            this.settingsPortBox.TabIndex = 3;
            this.settingsPortBox.Text = "23456";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(103, 331);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.Location = new System.Drawing.Point(197, 331);
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Size = new System.Drawing.Size(75, 23);
            this.settingsCancelButton.TabIndex = 5;
            this.settingsCancelButton.Text = "Cancel";
            this.settingsCancelButton.UseVisualStyleBackColor = true;
            this.settingsCancelButton.Click += new System.EventHandler(this.settingsCancelButton_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 62);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(103, 13);
            this.directoryLabel.TabIndex = 6;
            this.directoryLabel.Text = "Download Directory:";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(154, 59);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(143, 20);
            this.directoryBox.TabIndex = 7;
            this.directoryBox.Text = "Default - Techtella directory";
            // 
            // directoryBrowseButton
            // 
            this.directoryBrowseButton.Location = new System.Drawing.Point(303, 57);
            this.directoryBrowseButton.Name = "directoryBrowseButton";
            this.directoryBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.directoryBrowseButton.TabIndex = 8;
            this.directoryBrowseButton.Text = "Browse";
            this.directoryBrowseButton.UseVisualStyleBackColor = true;
            this.directoryBrowseButton.Click += new System.EventHandler(this.directoryBrowseButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 368);
            this.Controls.Add(this.directoryBrowseButton);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.settingsCancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsPortBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.peersUpDown);
            this.Controls.Add(this.maxPeersLabel);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.peersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maxPeersLabel;
        private System.Windows.Forms.NumericUpDown peersUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox settingsPortBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button settingsCancelButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button directoryBrowseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}