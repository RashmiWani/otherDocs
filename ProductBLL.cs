using PMSDAL;
using PMSEntities;
using PMSException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSBLL
{
    /// <summary>
    /// To create the Validation method and to invoke the opeartions from DAL
    /// Author: Arpeet Gokhale
    /// DOC: 4rd Oct 2018  
    /// </summary>
    public class ProductBLL
    {
        static List<Product> pList = new List<Product>();
        public bool AddProductBL(Product product)
        {
            bool isAdded = false;
            try
            {
                ProductDAL productOperations = new ProductDAL();
                if (ValidateProduct(product))
                {
                    isAdded = productOperations.AddProductDAL(product);
                }
                else
                {
                    throw new ProductException("validation Failed!!! Product details could not be verified ");
                }
                if (isAdded == false)
                {
                    throw new ProductException("Student Details not Added");

                }
            }
            catch (ProductException e)
            {
                throw e;
            }
            return isAdded;
        }
        private static bool ValidateProduct(Product product)
        {
            bool validproduct = true;
            StringBuilder message = new StringBuilder();
            if (product.ProductId <= 0 || product.ProductId > 10000)
            {
                message.Append(Environment.NewLine + "Invalid Product Id");
                validproduct = false;
            }
            if (product.ProductName == null || product.ProductName == string.Empty)
            {
                message.Append(Environment.NewLine + " Product Name cannot be blank");
                validproduct = false;
            }
            if (validproduct == false)
            {
                throw new ProductException(message.ToString());
            }
            return validproduct;
        }
        public List<Product> DisplayProductBL()
        {
            ProductDAL productOperations = new ProductDAL();
            try
            {
                pList = productOperations.DisplayProductDAL();
                if (pList.Count <= 0)
                {
                    throw new ProductException("No Records Found!!!");
                }
            }
            catch (ProductException e)
            {
                throw e;

            }
            return pList;
        }
    }
}
