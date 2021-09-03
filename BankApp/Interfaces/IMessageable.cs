using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IMessageable
    {
        public void SendMessage(string Message);
    }
}
