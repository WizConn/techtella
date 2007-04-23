using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Techtella
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BasicMultiServer TechServer = new BasicMultiServer();
            TechServer.RunThreaded();
            FileClass fcInit = new FileClass();
            Client InitClientData = new Client();
            Application.Run(new Form1(TechServer));
        }
    }
}