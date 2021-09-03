using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class WorkerService
    {
        public void ReturnTaxes(Worker Worker, Client Client, Message Message) {
            decimal taxes = Worker.CalculateTaxes(Client);
            string m = "";
            if (taxes == -1)
            {
                m = "Hola " + Client.Name + " " + Client.SecondName + "\n" +
                            "\t" + "No tiene fondos en la cuenta para calcular tasa.";
                Message.SendMessage(m);
            }
            else {
                m = "Hola " + Client.Name + " " + Client.SecondName + "\n" +
                            "\t" + "La tasa de su transferencia es del: " + taxes.ToString() + "%";
                Message.SendMessage(m);
            }
        }
    }
}
