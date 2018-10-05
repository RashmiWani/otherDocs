using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates2
{

    delegate int PerformArithmeticOperation(int x, int y);
    class AtithOp
    {
        static void DoOperation(int num1, int num2, PerformArithmeticOperation arOperation)
        {
            int z = arOperation(num1, num2);
            Console.WriteLine("{0} and {1} is:::{2}",num1,num2,z);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;


        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;

        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        static int Max(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public class CSharpAp
        {
            static void Main()
            {

                Console.WriteLine("******************************");
                Console.WriteLine("1.Addition::");
                Console.WriteLine("2.Subtraction::");
                Console.WriteLine("3.Multiplication::");
                Console.WriteLine("4.Divition::");
                Console.WriteLine("5.Maximum number::");
                Console.WriteLine("******************************");
                Console.WriteLine("enter choice::");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 1st number::");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter 2st number::");
                int b = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        DoOperation(a, b, Add);
                        break;
                    case 2:
                        DoOperation(a, b, Sub);
                        break;
                    case 3:
                        DoOperation(a, b, Multiply);
                        break;
                    case 4:
                        DoOperation(a, b, Divide);
                        break;
                    case 5:
                        DoOperation(a, b, Max);
                        break;
                  
                }
                Console.ReadKey();
            }

        }
    }
}
  