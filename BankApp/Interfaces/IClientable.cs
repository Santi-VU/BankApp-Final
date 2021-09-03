using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IClientable
    {
        public bool TransferFounds(Client Dest, decimal Founds);

        public void SetUser(User User);
    }
}
