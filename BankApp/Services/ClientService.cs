using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class ClientService
    {
        /// <summary>
        /// Realiza transferencia bancaria
        /// </summary>
        /// <param name="Origen"></param>
        /// <param name="Founds"></param>
        /// <param name="Dest"></param>
        /// <param name="Message"></param>
        public void PrepareTransfer(Client Origen, decimal Founds, Client Dest, Message Message) {
            if (Origen.TransferFounds(Dest, Founds)) {
                string m = "Hola " + Origen.Name + " " + Origen.SecondName + "\n" +
                                "\t" + "Su transferencia se ha realizado correctamente, Saldo actual: " + Origen.Account.Founds.ToString();
                Message.SendMessage(m);
                m = "Hola " + Dest.Name + " " + Dest.SecondName + "\n" +
                            "\t" + "Su transferencia se ha recibido correctamente, Saldo actual: " + Dest.Account.Founds.ToString();
                Message.SendMessage(m);
            }
        }
    }
}
