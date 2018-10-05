using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCcorp
{
    class InvalidCreditLimitException : ApplicationException
    {
        public InvalidCreditLimitException()
            : base()
        { }

        public InvalidCreditLimitException(string message)
            : base(message)
        { }
    }
}
