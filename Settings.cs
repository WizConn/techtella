using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            //do saving stuff
            this.Close();
        }
    }
}