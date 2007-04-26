using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Techtella
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void settingsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream filestream = new FileStream("settings.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(filestream);
            writer.Write(peersUpDown.Value.ToString() + "*" + settingsPortBox.Text + "*" + directoryBox.Text);
            writer.Close();
            filestream.Close();
            this.Close();
        }

        private void directoryBrowseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            directoryBox.Text = "" + folderBrowserDialog1.SelectedPath;
        }
    }
}