using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Objects
{
    class Message : IMessageable
    {
        public string MessageText;

        public Message() {
            //this.MessageText = MessageText;
        }

        public void SendMessage(string Message)
        {
            this.MessageText = Message;
            Console.WriteLine(Message);
        }
    }
}
