using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSException
{
    public class ProductException : ApplicationException
    {
        //Default Constructor, that inherits the base constructor
        public ProductException() : base()
        {

        }
        // Parameterized constructor for passing the error/exception message
        public ProductException(string Message) : base(Message)
        {

        }
    }
}
