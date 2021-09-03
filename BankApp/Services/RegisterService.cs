using BankApp.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Services
{
    class RegisterService
    {
        public void RegisterUser(Person P, Message Message) {
            P.User = P.User.RegisterUser(P.User.Name, P.User.Password, P.User.Worker);
            if (P.User == null)
            {
                Message.SendMessage("Hola " + P.Name + " " + P.SecondName + "\n" +
                  "\t" + "El registro ha sido incorrecto.");
            }
            else {
                Message.SendMessage("Hola " + P.Name + " " + P.SecondName + "\n" +
                  "\t" + "Su usuario: " + P.User.Name + " se ha creado con éxito.");
            }
        }
    }
}
