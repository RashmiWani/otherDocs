using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB8Q2_SameerHashTable
{
    class Program
    {
        static Hashtable GetHashtable()
        {
            // Create and return new Hashtable.
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }

        static void Main(string[] args)
        {
            //creating and diaplaying hashtable 
            Hashtable ht = GetHashtable();
            foreach (object k in ht.Keys)
            {
                Console.WriteLine("KEY : {0} \t VALUE : {1}", k, ht[k]);
            }

            //finding the key "Perimeter"
            bool key = ht.ContainsKey("Perimeter");
            if (key == true)
                Console.WriteLine("Key found in Hash Table");
            else
                Console.WriteLine("Key Not Found");
            Console.WriteLine("***********************************************\n");

            //Getting Values using INDEXERS
            int index = (int)ht["Area"];
            Console.WriteLine("Value for the Key AREA is {0}", index);
            Console.WriteLine("***********************************************\n");

            //Removing the entry for key "Mortgage"
            ht.Remove("Mortgage");
            Console.WriteLine("Mortgage Entry is removed");
            Console.WriteLine("***********************************************\n");

            //displaying the contents in hashtable
            Console.WriteLine("Key Value pairs after deletion are : ");
            foreach (object k in ht.Keys)
            {
                Console.WriteLine("KEY : {0} \t VALUE : {1}", k, ht[k]);
            }
            Console.WriteLine("***********************************************\n");

            Console.ReadKey();
        }
    }
}
