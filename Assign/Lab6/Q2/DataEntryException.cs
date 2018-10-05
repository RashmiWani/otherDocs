using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    class DataEntryException :ApplicationException
    {
        public DataEntryException()
            : base()
        { }

        public DataEntryException(string message)
            : base(message)
        { }



    }
}
