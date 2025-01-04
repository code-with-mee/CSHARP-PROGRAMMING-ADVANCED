using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _006_EventChatApplication.Model;

namespace _006_EventChatApplication
{
    public delegate void SendMessageDelegate(AMessage message);
    public class User
    {
        public event SendMessageDelegate OnSendMessageEvent;
        public string Name {  get; set; }

        public User() { }
        public User(string name)
        {
            Name = name;
        }

        public void SendTextMessage(User user,string content)
        {
            TextMessage textMessage = new TextMessage(user.Name,content);
            SendMessage(textMessage);
        }

        public void SendAudioMessage(User user, string audioUrl)
        {
            AudioMessage audioMessage = new AudioMessage(user.Name,audioUrl);
            SendMessage(audioMessage);
        }

        public void SendMessage(AMessage message) 
        {
            if(OnSendMessageEvent != null)
                OnSendMessageEvent(message);
        }

        public void RecievedMessageCallBack(AMessage message)
        {
            message.Display();
        }
    }
}
