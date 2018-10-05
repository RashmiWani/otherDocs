//class 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question1
{
    public class CreditCard
    {

        public int CreditCardLimit;

        public CreditCard(int creditCardLimit)
        {
            CreditCardLimit = creditCardLimit;
        }

        public int GetBalance()
        {
            return CreditCardLimit;
        }

        public int GetCreditLimit()
        {
            return 10000;
        }

        public void MakePayment(int amount)
        {
            string message = "";
            if (CreditCardLimit > amount)
            {
                CreditCardLimit = CreditCardLimit - amount;
                message = "Withdrawn Amount : " + amount + "\t Remaining Credit Crad Limit : " + CreditCardLimit;
            }
            else
            {
                message = "You are trying to pay greater amount than your current Credit Limit";
            }

            Bank b = new Bank();
            b.BankEvent += SMSGateway.SendMessage;
            b.Notify(message);
        }
    }
}
