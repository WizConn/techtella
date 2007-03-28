using System;
using System.Collections.Generic;
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
        public Form1()
        {
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
                ConnectWindow connectWindow = new ConnectWindow();
                connectWindow.ShowDialog();
            }
        }

    }
}