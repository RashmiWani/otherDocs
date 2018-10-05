using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public enum BankAccountTypeEnum { Current=1,Saving=2}

    interface IBankAccount {
        double GetBalance();
        void Deposit(double amount);
        bool Withdraw(double amount);
        bool Transfer(BankAccount toAccount, double amount);
        BankAccountTypeEnum AccountType { get; set; }

    }

    
    public abstract class BankAccount: IBankAccount
    {
        protected double balance;

        public double Balance { set { balance = value; }
        get { return balance; }
        }
       // protected double WithdrawAmt { set; get; }

        public void Deposit(double amount) {
            Balance = amount;
        }

        public abstract double GetBalance();
        public abstract bool Withdraw(double amount);
        public abstract bool Transfer(BankAccount toAccount,double amount);
        public BankAccountTypeEnum AccountType { get; set; }

    }
}
