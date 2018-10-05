using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate4Q
{
    delegate int Deligate(int n1, int n2);
    class ArithmeticOperations
    {
        static int num;

        public static int AddNum(int p, int q) => num = p + q;

        public static int SubNum(int p, int q) => num = p - q;

        public static int MultNum(int p, int q) => num = p * q;

        public static int DivNum(int p, int q) => num = p / q;

        public static int MaxNum(int p, int q) => (p > q) ? p : q;


        static void Main(string[] args)
        {
            Delegate n;
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
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2st number::");
            int n2 = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Deligate nc1 = new Deligate(AddNum);
                    int sum = nc1.Invoke(n1, n2);
                    Console.WriteLine("Value of Num: {0}", sum);
                    break;
                case 2:
                    Deligate nc2 = new Deligate(SubNum);
                    int sub = nc2(n1, n2);
                    Console.WriteLine("Value of Num: {0}", sub);
                    break;
                case 3:
                    Deligate nc3 = new Deligate(MultNum);
                    int mul = nc3(n1, n2);
                    Console.WriteLine("Value of Num: {0}", mul);
                    break;
                case 4:
                    Deligate nc4 = new Deligate(DivNum);
                    int div = nc4(n1, n2);
                    Console.WriteLine("Value of Num: {0}", div);
                    break;
                case 5:
                    Deligate nc5 = new Deligate(MaxNum);
                    int max = nc5(n1, n2);
                    Console.WriteLine("Value of Num: {0}", max);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
 

