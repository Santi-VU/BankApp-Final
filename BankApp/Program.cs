using BankApp.Objects;
using BankApp.Services;
using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientService ClientService = new ClientService();
            //MessageService MessageService = new MessageService();
            RegisterService UserService = new RegisterService();
            WorkerService WorkerService = new WorkerService();
            RegisterService RegisterService = new RegisterService();

            Message Message = new Message();

            User u1 = new User("Santi", "Comeras", false);
            Account ba1 = new Account("ES18 1111 2222 3333", 3500.75m);
            Client c1 = new Client("18061980B", "Santi", "Comeras", 27, 628212121, "scomeras@gmail.com", "00001C", 2, ba1);
            c1.SetUser(u1);

            User u2 = new User("Sonia", "Sanchez", false);
            Account ba2 = new Account("ES18 2222 1111 3333", 5000);
            Client c2 = new Client("18069388H", "Sonia", "Sanchez", 35, 654322211, "ssanchez@gmail.com", "00002C", 1, ba2);
            c1.SetUser(u2);

            ClientService.PrepareTransfer(c1, 1000, c2, Message);

            User uw1 = new User("18061980B", "18061980B", true);
            Worker w1 = new Worker("18061980B", "Santi", "Comeras", 27, 628212121, "scomeras@gmail.com", "00001W", 3, 1560.50m, c1);
            w1.SetUser(uw1);

            User uw2 = new User("18063325G", "18063325G", true);
            Worker w2 = new Worker("18063325G", "Diego", "Gracia", 28, 653421133, "gracia@gmail.com", "00002W", 6, 2100, null);
            w2.SetUser(uw2);

            WorkerService.ReturnTaxes(w1, w1.Client, Message);
            WorkerService.ReturnTaxes(w2, c2, Message);

            Account ba3 = new Account("ES18 3333 2222 1111", 300);
            Client c3 = new Client("18987388H", "Adrian", "Gomez", 31, 678223322, "agomez@gmail.com", "00003C", 0, ba2);
            c3.SetUser(new User("Adrian", "Gomez", false));
            RegisterService.RegisterUser(c3, Message);


        }
    }
}
