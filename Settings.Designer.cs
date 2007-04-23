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
            this.settingsPortBox.Text = "12345";
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 366);
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
    }
}