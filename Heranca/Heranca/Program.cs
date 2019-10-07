using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 100.0);

            BusinessAccount bAccount = new BusinessAccount(8010, "Marc Brown", 100.0, 500.0);          
            Console.WriteLine(bAccount.Balance);

            //UPCASTING
            //Account pode recer uma Business Account ou Saving Account
            Account acc1 = bAccount;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 100.0, 0.01);

            //DOWNCASTING
            //Fazendo Casting de uma Account(acc2) para um BusinessAcount;
            BusinessAccount acc4 = (BusinessAccount)acc2;
            //Chamando um método da BusinessAccount para testar o Casting;
            acc4.Loan(100.0);

            //Testando uma instancia antes de fazer o casting
            if (acc3 is BusinessAccount)
            {
                //Se acc3 é uma BusinessAccount, então acc5 recebe acc3;
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                //Outra forma de fazer o casting;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!!!");
            }

            //Testando uma instancia antes de fazer o casting
            if (acc3 is SavingsAccount)
            {
                //Se acc3 é uma SavingsAccount, então acc5 recebe acc3;
                SavingsAccount acc5 = (SavingsAccount)acc3;
                //acc5.UpdateBalance();
                Console.WriteLine("Update!!!");
            }

            acc.WithDraw(10.0);
            Console.WriteLine(acc.Balance);
            acc3.WithDraw(10.0);
            Console.WriteLine(acc3.Balance);
        }
    }
}
