using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Objects
{
    class Worker : Person, IWorkable, IClientable
    {
        public string WorkerIdentifier { get; protected set; }
        public int Antiquity { get; protected set; }
        public decimal Salary { get; protected set; }
        public Client Client { get; protected set; }

        public Worker(string Identifier, string Name, string SecondName, int Age, int Phone, string Email,
                            string WorkerIdentifier, int Antiquity, decimal Salary, Client Client)
        {
            this.Identifier = Identifier;
            this.Name = Name;
            this.SecondName = SecondName;
            this.Age = Age;
            this.Phone = Phone;
            this.Email = Email;
            //this.User = User;
            this.WorkerIdentifier = WorkerIdentifier;
            this.Antiquity = Antiquity;
            this.Salary = Salary;
            this.Client = Client;
        }

        public bool TransferFounds(Client Dest, decimal Founds)
        {
            if (this.Client.Account.ValidateFounds(Founds))
            {
                this.Client.Account.RemoveFounds(Founds);
                Dest.Account.AddFounds(Founds);
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal CalculateTaxes(Client Client)
        {
            if (Client.Account.Founds == 0) 
            {
                return -1;
            }
            else if (Client.Account.Founds < 1000)
            {
                return 2;
            }
            else if (Client.Account.Founds >= 1000 && Client.Account.Founds < 2000)
            {
                return 1.5m;
            }
            else if (Client.Account.Founds >= 2000 && Client.Account.Founds < 3000)
            {
                return 1;
            }
            else {
                return 0.5m;
            }
        }

        public void SetUser(User User)
        {
            this.User = User;
        }
    }
}
