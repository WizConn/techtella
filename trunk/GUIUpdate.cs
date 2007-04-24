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
                ArrayList currentMessages = (ArrayList)owner.chatMessages.Clone();
                ArrayList qhits = (ArrayList)owner.queryHits.Clone();
                foreach(object message in currentMessages)
                {
                    chatOutput += message.ToString();
                }
                target.SetText(chatOutput);
                target.stats.statisticsUpdate();
                target.updateStats();
                target.updateFoundPeers();
                target.updateChatUsers();
                target.SearchFiller(qhits);
                
            }
        }

        public void RunThreaded()
        {
            Thread threadedRun = new Thread(Run);
            threadedRun.Start();
        }
    }
}