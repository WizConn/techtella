using System;
using System.Threading;
using System.Collections;

namespace Techtella
{
    public class GUIUpdate
    {
        public BasicMultiServer owner;
        public Form1 target;

        public GUIUpdate(BasicMultiServer own, Form1 toUpdate) 
        {
            owner = own;
            target = toUpdate;
        }

        private void Run() 
        {
            Console.WriteLine("Started the GUI Updater");
            while (true)
            {
                string chatOutput = "";
                ArrayList currentMessages = owner.chatMessages;
                foreach(object message in currentMessages)
                {
                    chatOutput += message.ToString();
                }
                target.chatOutputBox.Text = chatOutput;
            }
        }

        public void RunThreaded()
        {
            Thread threadedRun = new Thread(Run);
            threadedRun.Start();
        }
    }
}