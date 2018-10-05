using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace BankTypes
{
    public class ICICI:BankAccount  {
        double minimumBalance=1000;

        public override bool Withdraw(double amount) {
            bool success = false;
            if (Balance - amount > 0)
            {
                Balance = Balance - amount;
                success = true;
            }
            else {
                Console.WriteLine($"Entered amount is more than the balance, enter less than {Balance} ");
            }

            return success;
        }


        public override bool Transfer(BankAccount toAccount, double amount) {
            bool success = false;
            if (this.Balance - amount >= minimumBalance)
            {
                this.Balance = this.Balance - amount;
                
                toAccount.Balance = toAccount.Balance + amount;
                success = true;
            }
            else {
                Console.WriteLine($"minimum Balance should be  {minimumBalance}, enter less than {Balance-1000}");
            }
           return success;
        }

        public override double GetBalance()
        {
            return Balance;
        }
    }



    public class HSBC : BankAccount
    {
        double minimumBalance=5000;

        public override bool Withdraw(double amount)
        {
            bool success = false;
            if (Balance - amount >=minimumBalance)
            {
                Balance = Balance - amount;
                success = true;
            }
            else
            {
                Console.WriteLine($"Entered amount is more , enter less than {Balance-minimumBalance} ");
            }

            return success;
        }


        public override bool Transfer(BankAccount toAccount, double amount)
        {
            bool success = false;
            if (this.Balance - amount >= minimumBalance)
            {
                this.Balance = this.Balance - amount;

                toAccount.Balance = toAccount.Balance + amount;
                success = true;
            }
            else
            {
                Console.WriteLine($"minimum Balance should be  {minimumBalance}, enter less than {Balance - 1000}");
            }
            return success;
        }

        public override double GetBalance()
        {
            return Balance;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
           //******************       ICICI          **************************
            ICICI i1 = new ICICI();
            i1.AccountType = BankAccountTypeEnum.Saving;
            Console.WriteLine("Enter the amount to be deposited in the savings account of ICICI");
            i1.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Balance in savings account is { i1.GetBalance()}\n");

            ICICI i2 = new ICICI();
            i2.AccountType = BankAccountTypeEnum.Current;
            Console.WriteLine("Enter the amount to be deposited in the current account of ICICI");
            i2.Deposit(int.Parse(Console.ReadLine()));
           // i2.GetBalance();
            Console.WriteLine($"Balance in current account is {i2.GetBalance()}\n");

            Console.WriteLine("Enter the amount to transfer from saving's to current : ");
            bool icici=i1.Transfer(i2, int.Parse(Console.ReadLine()));
            if (icici)
            {
                Console.WriteLine($"After transfer Balance in savings account is {i1.GetBalance()}");
                Console.WriteLine($"After transfer Balance in current account is {i2.GetBalance()}\n");
            }

            //**************************            HSBC          ********************
            HSBC h1 = new HSBC();
            h1.AccountType = BankAccountTypeEnum.Saving;
            Console.WriteLine("Enter the amount to be deposited in the savings account of HSBC");
            h1.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Balance in savings account is { h1.GetBalance()}\n");

            HSBC h2 = new HSBC();
            h2.AccountType = BankAccountTypeEnum.Current;
            Console.WriteLine("Enter the amount to be deposited in the current account of HSBC ");
            h2.Deposit(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Balance in current account is {h2.GetBalance()}");

            Console.WriteLine("Enter the amount to transfer from saving's to current in HSBC : ");
            bool hsbc=h1.Transfer(h2, int.Parse(Console.ReadLine()));
            if (hsbc)
            {
                Console.WriteLine($"After transfer Balance in savings account is {h1.GetBalance()}");
                Console.WriteLine($"After transfer Balance in current account is {h2.GetBalance()}");
            }



            Console.ReadKey();
        }
    }
}
