using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagment
{
    class Program
    {
        public static void PrintMenu()
        {

            Console.WriteLine("\n1. Add Contact");
            Console.WriteLine("2. Display Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. ShowAll Contacts");
            Console.WriteLine("5. Exit");

        }
        public static void AddContact(ref List<Contact> MyContactList)
        {
            Contact NewContact = new Contact();

            Console.Write("Enter Contact Number : ");
            NewContact.ContactNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Contact Name : ");
            NewContact.ContactName = Console.ReadLine();

            Console.Write("Enter Cell Number : ");
            NewContact.CellNo = Console.ReadLine();
            MyContactList.Add(NewContact);
        }
        public static void DisplayContact(ref List<Contact> MyContactList)
        {
            Console.Write("Enter Name of Contact You Want To View : ");
            string ContactName = Console.ReadLine();
            Contact contact = MyContactList.Find(c => c.ContactName == ContactName);
            if (contact != null)
            {
                Console.WriteLine("\nContact No. : " + contact.ContactNo);
                Console.WriteLine("Conact Name. : " + contact.ContactName);
                Console.WriteLine("Cell No. : " + contact.CellNo);
            }
            else
                Console.WriteLine("No Contact Found");
        }
        public static void EditContact(ref List<Contact> MyContactList)
        {
            Console.Write("Enter Name of Contact You Want To Update : ");
            string UpdateQueryName = Console.ReadLine();
            Contact ContactToBeUpdated = MyContactList.Find(c => c.ContactName == UpdateQueryName);
            if (ContactToBeUpdated != null)
            {
                Console.Write("\nEnter New Contact No. : ");
                ContactToBeUpdated.ContactNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter New Contact Name : ");
                ContactToBeUpdated.ContactName = Console.ReadLine();

                Console.Write("\nEnter New Cell No. : ");
                ContactToBeUpdated.CellNo = Console.ReadLine();
                MyContactList[MyContactList.IndexOf(ContactToBeUpdated)] = ContactToBeUpdated;
                Console.WriteLine("\nContact Updated Successfully\n");
            }
            else
                Console.WriteLine("No Saved Details Found,Contact Not Updated");
        }
        public static void ShowAllContacts(ref List<Contact> MyContactList)
        {
            if (MyContactList != null)
            {
                foreach (Contact SavedContact in MyContactList)
                {
                    Console.WriteLine("Contact No. : " + SavedContact.ContactNo);
                    Console.WriteLine("Contact Name : " + SavedContact.ContactName);
                    Console.WriteLine("Cell No. : " + SavedContact.CellNo);
                }

            }
            else
                Console.WriteLine("No Details Saved Yet Please SAve Some Contatcs Fitrst");
        } 

        static void Main(string[] args)
        {
            int choice;
            List<Contact> MyContactList = new List<Contact>();
            do
            {
                Console.Write("\nChoose Operation :  ");
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Program.AddContact(ref MyContactList);
                        break;
                    case 2:
                        Program.DisplayContact(ref MyContactList);
                       break;
                    case 3:
                        Program.EditContact(ref MyContactList);
                         break;
                    case 4:
                        Program.ShowAllContacts(ref MyContactList);
                       
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("enter A Valid Choice");
                        break;

                }
            }
            while (choice != 5);

        }
    }
}
