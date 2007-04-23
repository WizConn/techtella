namespace Techtella
{
    partial class ConnectWindow
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
            this.ipAddrLabel = new System.Windows.Forms.Label();
            this.connectLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.connectPeerIPBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipAddrLabel
            // 
            this.ipAddrLabel.AutoSize = true;
            this.ipAddrLabel.Location = new System.Drawing.Point(12, 36);
            this.ipAddrLabel.Name = "ipAddrLabel";
            this.ipAddrLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAddrLabel.TabIndex = 0;
            this.ipAddrLabel.Text = "IP Address:";
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLabel.Location = new System.Drawing.Point(12, 9);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(157, 13);
            this.connectLabel.TabIndex = 2;
            this.connectLabel.Text = "Enter a peer to connect to";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 96);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Enter += new System.EventHandler(this.Button_Click);
            this.connectButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(104, 96);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // connectPeerIPBox
            // 
            this.connectPeerIPBox.Location = new System.Drawing.Point(79, 33);
            this.connectPeerIPBox.Name = "connectPeerIPBox";
            this.connectPeerIPBox.Size = new System.Drawing.Size(100, 20);
            this.connectPeerIPBox.TabIndex = 1;
            // 
            // ConnectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 133);
            this.Controls.Add(this.connectPeerIPBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.connectLabel);
            this.Controls.Add(this.ipAddrLabel);
            this.MaximizeBox = false;
            this.Name = "ConnectWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConnectWindow";
            this.Load += new System.EventHandler(this.ConnectWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipAddrLabel;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox connectPeerIPBox;
    }
}