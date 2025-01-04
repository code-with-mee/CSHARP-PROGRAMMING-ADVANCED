using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_EventChatApplication
{
    public class App
    {
        public void Run()
        {
            //event chatapp
            User a = new User("A");
            User b = new User("B");

            a.OnSendMessageEvent += a.RecievedMessageCallBack;
            b.OnSendMessageEvent += b.RecievedMessageCallBack;

            a.SendTextMessage(b, "Hello B");
            b.SendTextMessage(a, "Hello welome A");
        }
    }
}
