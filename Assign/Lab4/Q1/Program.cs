using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmployeeProject
{


  public abstract class Employee
    {
        

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public  abstract double GetSalary();
            
           }


    public class ContractEmployee : Employee
    {
        public int Perks { set; get; }

        public override double GetSalary() {
            return Salary + Perks;
        }
    }

    public class PermanentEmployee : Employee
    {
        public int NoOfLeaves { set; get; }
        public int ProvidendFund { set; get; }

        public override double GetSalary() {

            return Salary-ProvidendFund;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'y';
            do
            {
                WriteLine("Select a type of employee\n1.Contract Employee\n2.PErmanent Employee\n");
                switch (int.Parse(ReadLine()))
                {
                    case 1:
                        ContractEmployee c = new ContractEmployee();
                        WriteLine("enter employee id");
                        c.EmpId = int.Parse(ReadLine());
                        WriteLine("enter employee name");
                        c.EmpName = ReadLine();
                        WriteLine("enter employee department");
                        c.Department = ReadLine();
                        WriteLine("enter employee city");
                        c.City = ReadLine();
                        WriteLine("enter employee address");
                        c.Address = ReadLine();
                        WriteLine("enter employee salary");
                        c.Salary = int.Parse(ReadLine());

                        WriteLine("enter  perks");
                        c.Perks = int.Parse(ReadLine());
                        WriteLine($"Contract Employee salary is  {c.GetSalary()}");


                        break;
                    case 2:
                        PermanentEmployee p = new PermanentEmployee();
                        WriteLine("enter employee id");
                        p.EmpId = int.Parse(ReadLine());
                        WriteLine("enter employee name");
                        p.EmpName = ReadLine();
                        WriteLine("enter employee department");
                        p.Department = ReadLine();
                        WriteLine("enter employee city");
                        p.City = ReadLine();
                        WriteLine("enter employee address");
                        p.Address = ReadLine();
                        WriteLine("enter employee salary");
                        p.Salary = int.Parse(ReadLine());

                        WriteLine("enter  number of leaves");
                        p.NoOfLeaves = int.Parse(ReadLine());

                        WriteLine("enter Providend fuund");
                        p.ProvidendFund = int.Parse(ReadLine());
                        WriteLine($"Permanent Employee salary is { p.GetSalary()}");

                        break;
                    default: WriteLine("wrong entry"); break;
                }
                WriteLine("Do you wish to continue ?  y/n ");
            } while (choice == char.Parse(ReadLine()));


            ReadKey();
        }
    }
}

