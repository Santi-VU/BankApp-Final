using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Interfaces
{
    interface IWorkable
    {
        public decimal CalculateTaxes(Client Client);
    }
}
