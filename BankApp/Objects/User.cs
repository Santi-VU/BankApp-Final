using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Objects
{
    class User : IUserable, IRegisterable
    {
        public string Name { get; protected set; }
        public string Password { get; protected set; }
        public bool Worker { get; protected set; }

        public User(string Name, string Password, bool Worker) {
            this.Name = Name;
            this.Password = Password;
            this.Worker = Worker;
        }

        public bool ValidateRegister(User User)
        {
            if (User.Name.Equals(""))
            {
                return false;
            }

            if (User.Password.Equals(""))
            {
                return false;
            }

            return true;
        }

        public User RegisterUser(string Name, string Password, bool Worker)
        {
            User User = new User(Name, Password, Worker);
            if (User.ValidateRegister(User))
            {
                return User;
            }
            else
            {
                return null;
            }
        }
    }
}
