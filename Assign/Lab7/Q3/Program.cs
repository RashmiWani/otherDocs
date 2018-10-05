using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace EmployeeApplication
{
    public class Program
    {
        
        //Print Menu
        public static void PrintMenu()
        {
            Console.WriteLine("\n1. Add Employee");
            Console.WriteLine("2. Display All Employees");
            Console.WriteLine("3. Delete Employee Data");
            Console.WriteLine("4. Search Employee");
            Console.WriteLine("5. Exit");
        }

        //Add Employee
        public static void AddEmployee(ref List<Employee> EmployeeList)
        {
            int id;
            string name;
            double salary, provF;
            
            
            Console.WriteLine("Enter EmployeeID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Employee Provident Fund: ");
            provF = Convert.ToDouble(Console.ReadLine());

            Employee empAdd = new Employee(id,name,salary,provF); //Paramterized Constructor
            EmployeeList.Add(empAdd);
        }


        //Display Records
        public static void ReturnAllRecords(ref List<Employee> EmployeeList)
        {
            if (EmployeeList != null)
            {
                foreach (Employee emp in EmployeeList)
                {
                    Console.WriteLine("\nEmployee ID: " + emp.empId);
                    Console.WriteLine("Employee Name: " + emp.empName);
                    Console.WriteLine("Employee Salary: " + emp.empSalary);
                    Console.WriteLine("Employee Provident Fund: " + emp.provFund);
                }
            }
        }

        //Search Employees
        public static void SearchEmployee(ref List<Employee> EmployeeList)
        {
            Console.WriteLine("Enter EmpID of Employee You Want To Search : ");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());

            Employee searchEmployee = EmployeeList.Find(e => e.empId == EmployeeID);
            if (searchEmployee!=null)
            {
                Console.WriteLine("\nEmployee ID: " + searchEmployee.empId);
                Console.WriteLine("Employee Name: " + searchEmployee.empName);
                Console.WriteLine("Employee Salary: " + searchEmployee.empSalary);
                Console.WriteLine("Employee Provident Fund: " + searchEmployee.provFund);
            }else
                Console.WriteLine("No Record Found");


        }

        //Delete Records
        public static void DeleteEmployee(ref List<Employee> EmployeeList)
        {
            Console.WriteLine("\nEnter EmpID of Employee You Want Delete : ");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());
            

            Employee deleteEmployee = EmployeeList.Find(e => e.empId == EmployeeID);
            if(deleteEmployee!=null)          
            {
                EmployeeList.Remove(deleteEmployee);
                Console.WriteLine("Record Deleted");
            }else
            {
                Console.WriteLine("Employee Not Found");
            }
            
        }



        static void Main(string[] args)
        {
            int choice;
            //Generic Employee
            List<Employee> EmployeeList = new List<Employee>();

            do
            {
                Console.Write("\nChoose Operation :  ");
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Program.AddEmployee(ref EmployeeList);
                        break;
                    case 2:
                        Program.ReturnAllRecords(ref EmployeeList);
                        break;
                    case 3:
                        Program.DeleteEmployee(ref EmployeeList);
                        break;
                    case 4:
                        Program.SearchEmployee(ref EmployeeList);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter A Valid Choice");
                        break;
                }

            } while (choice != 5);

        }
    }
}
