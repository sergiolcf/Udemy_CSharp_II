using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upcasting_Downcasting.Entities;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting
            account = businessAccount;

            Account acc = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc2 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //Downcasting

            BusinessAccount bsa = (BusinessAccount)acc;
            bsa.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc2;

            if (acc2 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc2;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");

                BusinessAccount acc6 = acc2 as BusinessAccount;
            }

            if (acc2 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc2;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }

        }
    }
}
