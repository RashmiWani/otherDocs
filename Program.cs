using PMSBLL;
using PMSEntities;
using PMSException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSPL
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                PrintMenu();
                Console.WriteLine("Enter your Choice:");
                bool chkChoice;
                chkChoice = int.TryParse(Console.ReadLine(), out choice);
                if (!chkChoice) { Console.WriteLine("Invalid Input"); }
                switch (choice)
                {
                    case 1:
                        AddProductPL();
                        break;
                    case 2:
                        DisplayProductPL();
                        break;
                                           
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 0);
        }
        public static void PrintMenu()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("Product Management System (PMS)");
            Console.WriteLine("Press 1 To Add New Product");
            Console.WriteLine("Press 2 To Display All Product");
            
            Console.WriteLine("Press 0 To Exit");
            Console.WriteLine("===========================================================");
        }
        public static void AddProductPL()
        {
            try
            {
                Product objProduct = new Product();
                Console.WriteLine("Enter the Product Id:");
                bool chkid;
                int ProductId;
                //Use TryParse to chk if the entered value is parseable or not
                chkid = Int32.TryParse(Console.ReadLine(), out ProductId);
                //If the Parsing fails, throw the Exception
                if (chkid == false)
                {
                    throw new ProductException("Invalid Entry");
                }
                //If the Parsing is successful, store the ProductId into the Entity 
                else
                {
                    objProduct.ProductId = ProductId;
                }
                Console.WriteLine("Enter Product name:");
                objProduct.ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Price:");
                objProduct.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Date of Manufacture");
                objProduct.DateOfManufacture = DateTime.Parse(Console.ReadLine());

                ProductBLL bllobj = new ProductBLL();
                if (bllobj.AddProductBL(objProduct) == false)
                {
                    throw new ProductException("Product Record could not be added ");

                }
                else
                {
                    Console.WriteLine("Product Details added successfully");
                }
            }
            catch (ProductException Exception)
            {
                Console.WriteLine("Error occured " + Exception.Message);
            }


        }
        public static void DisplayProductPL()
        {
            try
            {
                ProductBLL bllobj = new ProductBLL();
                List<Product> pList = new List<Product>();
                pList = bllobj.DisplayProductBL();
                Console.WriteLine("Product Details");
                Console.WriteLine("===========================");
                foreach (Product p in pList)
                {
                    Console.WriteLine("Product Id: {0} \t Product Name:{1} \t Product Price: {2} \t  Date of Manufacturing: {3}", p.ProductId, p.ProductName, p.Price, p.DateOfManufacture );
                }
            }
            catch (ProductException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    
    }
}
