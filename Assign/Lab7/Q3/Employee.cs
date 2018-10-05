using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        private int EmpID;
        public int empId {
            get {return EmpID; }
            set {EmpID = value; }
        }

        private string EmpName;
        public string empName {
            get { return EmpName; }
            set{EmpName = value; }
        }

        private double EmpSalary;
        public double empSalary
        {
            get { return EmpSalary; }
            set {EmpSalary = value; }
        }

        private double Pf;
        public double provFund {
            get { return Pf; }
            set { Pf = value; }
        }

        public Employee()
        {
            EmpID = 0;
            EmpName = string.Empty;
            EmpSalary = 0.0;
            Pf = 0.0;
        }

        public Employee(int employeeID,string name,double sal,double pf)
        {
            this.EmpID = employeeID;
            this.EmpName = name;
            this.EmpSalary = sal;
            this.Pf = pf;
        }

    }
}
