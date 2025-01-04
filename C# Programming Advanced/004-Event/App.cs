using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _004_Event
{
    public delegate void SendMessageDelegate(string message);   
    public class App
    {
        public event SendMessageDelegate SendMessage;
        public void Run()
        {
            //event
            //what is event?
            SendMessage += Message;

            if (SendMessage != null)
                SendMessage("Hello world");
        }

        private void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
