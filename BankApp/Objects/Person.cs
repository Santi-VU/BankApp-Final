using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Objects
{
    abstract class Person
    {
        public string Identifier { get; protected set; }
        public string Name { get; protected set; }
        public string SecondName { get; protected set; }
        public int Age { get; protected set; }
        public int Phone { get; protected set; }
        public string Email { get; protected set; }
        public User User { get; set; }
    }
}
