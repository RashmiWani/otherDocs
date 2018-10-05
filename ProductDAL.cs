using PMSEntities;
using PMSException;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PMSDAL
{

    /// <summary>
    /// To create the methods for performing operations on Product Entity
    /// Author: Arpeet Gokhale
    /// DOC: 4th Oct 2018  
    /// </summary>
    public class ProductDAL
    {

        static List<Product> productList = new List<Product>();
        /// <summary>
        /// Function for inserting data into the list
        /// </summary>
        /// <param name="newproduct"></param>
        /// <return>boolean value if user is added or not</return>

        public bool AddProductDAL(Product newproduct)
        {
            bool isProductAdded = false;
            try
            {
                productList.Add(newproduct);
                SerializeProductDAL();
                isProductAdded = true;
            }

            catch (ProductException)
            {
                throw;
            }
            return isProductAdded;

        }
        /// <summary>
        /// Function for serializing Product List
        /// </summary>
        /// <returns>List of Product</returns>
        public static void SerializeProductDAL()
        {
            FileStream fStream = null;
            try
            {
                fStream = new FileStream("ProductList.ser", FileMode.Create, FileAccess.Write);
                BinaryFormatter Formatter = new BinaryFormatter();
                Formatter.Serialize(fStream, productList);
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fStream.Close();
            }

        }
        /// <summary>
        /// Function for displaying the data from the Product List
        /// /// </summary>
        /// <returns>List of Product</returns>
        public List<Product> DisplayProductDAL()
        {
            return DeserializeProductDAL();
        }

        public List<Product> DeserializeProductDAL()
        {
            List<Product> deserializedData = null;
            FileStream fStream = null;
            try
            {
                fStream = new FileStream("ProductList.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter Formatter = new BinaryFormatter();
                deserializedData = (List<Product>)Formatter.Deserialize(fStream);


            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                fStream.Close();
            }
            return deserializedData;
        }
    }
}
