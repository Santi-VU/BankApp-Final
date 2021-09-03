using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Objects
{
    class Client : Person, IClientable
    {
        public string ClientIdentifier;
        public int Antiquity;
        public Account Account;

        public Client(string Identifier, string Name, string SecondName, int Age, int Phone, string Email,
                            string ClientIdentifier, int Antiquity, Account Acc) {
            this.Identifier = Identifier;
            this.Name = Name;
            this.SecondName = SecondName;
            this.Age = Age;
            this.Phone = Phone;
            this.Email = Email;
            //this.User = User;
            this.ClientIdentifier = ClientIdentifier;
            this.Antiquity = Antiquity;
            this.Account = Acc;
        }

        public void SetUser(User User)
        {
            this.User = User;
        }

        public bool TransferFounds(Client Dest, decimal Founds)
        {
            if (this.Account.ValidateFounds(Founds))
            {
                this.Account.RemoveFounds(Founds);
                Dest.Account.AddFounds(Founds);
                return true;
            }
            else {
                return false;
            }
        }
    }
}
