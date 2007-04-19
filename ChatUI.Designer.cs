namespace Techtella
{
    partial class Chat
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
            this.output = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.RichTextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.output.Size = new System.Drawing.Size(435, 199);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 217);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(354, 72);
            this.input.TabIndex = 1;
            this.input.Text = "";
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputText);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(372, 217);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 72);
            this.send.TabIndex = 2;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.ChatClick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 301);
            this.Controls.Add(this.send);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.MaximumSize = new System.Drawing.Size(467, 328);
            this.MinimumSize = new System.Drawing.Size(467, 328);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Button send;
    }
}