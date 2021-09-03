using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IAccountable
    {
        public void AddFounds(decimal Founds);
        public void RemoveFounds(decimal Founds);
        public bool ValidateFounds(decimal Founds);
    }
}
