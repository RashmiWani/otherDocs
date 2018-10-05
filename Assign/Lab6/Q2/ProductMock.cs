using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    public class ProductMock
    {
        private int productID;
        private string productname;
        private double productprice;


        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public double ProductPrice
        {
            get { return productprice; }
            set { productprice = value; }
        }

        public ProductMock()
        {

        }
        public ProductMock(int productID, string productname, double productprice)
        {
            this.productID = productID;
            this.productname = productname;
            this.productprice = productprice;

        }

    }
}
