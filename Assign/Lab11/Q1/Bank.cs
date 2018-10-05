using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question1
{
    class Bank
    {
        public delegate void BankDelegate(string message);
        public event BankDelegate BankEvent;

        public void Notify(string message)
        {
            if (BankEvent != null)
                BankEvent(message);
        }
    }
}
