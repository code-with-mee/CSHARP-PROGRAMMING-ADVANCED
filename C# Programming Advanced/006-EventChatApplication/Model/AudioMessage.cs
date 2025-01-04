using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_EventChatApplication.Model
{
    public class AudioMessage : AMessage
    {
        public string AudioUrl {  get; set; }

        public AudioMessage() { }
        public AudioMessage(string sender,string audioUrl)
        {
            Sender = sender;
            AudioUrl = audioUrl;    
        }
        public override void Display()
        {
            Console.WriteLine("{0} recieved audio url {1}",
                Sender,AudioUrl);
        }
    }
}
