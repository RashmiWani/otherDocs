using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //Add this library

namespace Lab8Q1
{
    class Program
    {
        public static void DisplayMenu()
        {

            Console.WriteLine("1. Add Record");
            Console.WriteLine("2. Display Record");
            Console.WriteLine("3. Search Record");
            Console.WriteLine("4. Count of Records");
            Console.WriteLine("5. Delete Record");
            Console.WriteLine("6. Exit");
        }

        public static void  AddRecord(Hashtable ht)
        {
            ht.Add("MH01", "Mumbai");
            ht.Add("BG02", "Bangalore");
            ht.Add("HY03", "Hyderabad");
            ht.Add("TH04", "Thane");
            ht.Add("PN05", "Pune");
        }

        public static void DisplayRecord(Hashtable ht)
        {
            Console.WriteLine("The data in hashtable is:");
            foreach (string item in ht.Keys)
            {
                Console.Write("key is : " + item + "\t");
                Console.Write("Value is :" + ht[item]);
                Console.WriteLine();
            }
        }

        public static void SearchRecord(Hashtable ht)
        {
            Console.WriteLine("Enter the key you want to search");
            string key = Console.ReadLine();
            if (ht.ContainsKey(key))
                Console.WriteLine("Key {0} is found in hashtable and value is {1}", key, ht[key]);
            else
                Console.WriteLine("key {0} is not found in hashtable", key);
        }

        public static void CountRecords(Hashtable ht)
        {
            Console.WriteLine("Total number of records in hashtable are:" + ht.Count);
        }

        public static void DeleteRecord(Hashtable ht)
        {
            Console.WriteLine("Enter the key which you want to remove");
            string remove = Console.ReadLine();
            ht.Remove(remove);
            Console.WriteLine("The record is removed and remaining data in hashtable is:");
            foreach (string item in ht.Keys)
            {
                Console.Write("key is : " + item + "\t");
                Console.Write("Value is :" + ht[item]);
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            
            Hashtable ht = new Hashtable();
            int choice;
            do
            {
                DisplayMenu();
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Program.AddRecord(ht);
                        break;
                    case 2:
                        Program.DisplayRecord(ht);
                        break;
                    case 3:
                        Program.SearchRecord(ht);
                        break;
                    case 4:
                        Program.CountRecords(ht);
                        break;
                    case 5:
                        Program.DeleteRecord(ht);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            } while (choice != 6);
       Console.ReadKey();
        }
    }
}
