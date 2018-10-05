using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCcorp
{
    public class Customer
    {
        public int CustomerID;
        public int ID { get; set; }

        public string CustName;
        public string Name { get; set; }

        public string CustAddress;
        public string Address { get; set; }

        public string CustCity;
        public string City { get; set; }

        public string CustPhoneNo;
        public string PhoneNo { get; set; }

        public int CustCreditLimit;
        public int CreditLimit { get; set; }

        public Customer()
        {
            CustomerID = 0;
            CustName = "";
            CustAddress = "";
            CustCity = "";
            CustPhoneNo = "";
            CustCreditLimit = 0;
        }

        public Customer(int CustomerID, string CustomerName, string Address, string City, string PhoneNo, int CreditLimit)
        {
            this.CustomerID = CustomerID;
            this.CustName = CustomerName;
            this.CustAddress = Address;
            this.CustCity = City;
            this.CustPhoneNo = PhoneNo;
            this.CustCreditLimit = CreditLimit;
        }
    }
}
