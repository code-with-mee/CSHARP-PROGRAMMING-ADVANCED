using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_EventChatApplication.Model
{
    public abstract class AMessage
    {
        public string Sender {  get; set; }
        public abstract void Display();

    }
}
