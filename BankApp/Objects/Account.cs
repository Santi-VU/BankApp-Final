using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Objects
{
    class Account : IAccountable
    {
        public string IBAN { get; protected set; }
        public decimal Founds { get; protected set; }

        public Account(string IBAN, decimal Founds) {
            this.IBAN = IBAN;
            this.Founds = Founds;
        }

        public void AddFounds(decimal Founds)
        {
            this.Founds += Founds;
        }

        public void RemoveFounds(decimal Founds)
        {
            this.Founds -= Founds;
        }

        public bool ValidateFounds(decimal Founds)
        {
            if (this.Founds < Founds)
            {
                return false;
            }
            return true;
        }
    }
}
