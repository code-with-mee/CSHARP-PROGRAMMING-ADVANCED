using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_EventChatApplication.Model
{
  
    public class TextMessage : AMessage
    {
        public string Content { get; set; }

        public TextMessage() { }
        public TextMessage(string sender,string content)
        {
            Content = content;
            Sender = sender;
        }
        public override void Display()
        {
            Console.WriteLine("{0} recieved message => {1}",
                Sender,Content);
        }
    }
}
