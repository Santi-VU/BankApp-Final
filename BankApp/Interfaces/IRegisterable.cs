using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IRegisterable
    {
        public User RegisterUser(string Name, string Password, bool Worker);
    }
}
