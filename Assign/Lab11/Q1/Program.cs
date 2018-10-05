// console application
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace Lab11Question1
{
   
class Program
    {
        static void Main(string[] args)
        {

            // The Credit limit is set to 10000 initially.

            CreditCard c = new CreditCard(10000);

            Console.WriteLine("***************************Payment Gateway***************************");

            Console.WriteLine("Your current Credit Card limit is 10000 Rupees.");
            
            Console.Write("Please enter the amount for making payment : ");

            int amount = Convert.ToInt32(Console.ReadLine());

            c.MakePayment(amount);

            int choice;

            while(true)
            {
                Console.Write("\n Do you wish to continue with another Payment press 1 else exit :");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Please enter the amount for making payment : ");

                    amount = Convert.ToInt32(Console.ReadLine());

                    c.MakePayment(amount);
                }
                else
                    Environment.Exit(1);
            }

            Console.ReadKey();
        }
    }
}
