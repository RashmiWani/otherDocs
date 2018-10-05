using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCcorp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            Console.Write("Enter the Customer ID : ");
            c.CustomerID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Customer Name : ");
            c.CustName = Console.ReadLine();

            Console.Write("Enter the Customer Address : ");
            c.CustAddress = Console.ReadLine();

            Console.Write("Enter the City : ");
            c.CustCity = Console.ReadLine();

            Console.Write("Enter the Customer Phone Number : ");
            c.CustPhoneNo = Console.ReadLine();

            try
            {
                Console.Write("How much credit you want : ");
                c.CustCreditLimit = Convert.ToInt32(Console.ReadLine());

                if (c.CustCreditLimit > 50000)
                    throw new InvalidCreditLimitException("Limit of credit is Rs 50000, please insert a value under credit limit");

            }

            catch (InvalidCreditLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
