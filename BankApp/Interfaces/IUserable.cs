using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IUserable
    {
        public bool ValidateRegister(User User);
    }
}
