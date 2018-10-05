using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BatchDetailsOperations
{
    class Program
    {
        static FileStream fs;
        static StreamWriter sw;

        public static void DisplayMenu()
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("Welcome to Batch Details Portal");
            Console.WriteLine("1. Create a Directory");
            Console.WriteLine("Note : Option 2 will work only after Option 1");
            Console.WriteLine("2. Enter the Batch Details Content");
            Console.WriteLine("3. Create a Backup copy of the Academy folder in D Drive");
            Console.WriteLine("4. View the details of the text files");
            Console.WriteLine("5. Exit Window!");
            Console.WriteLine("********************************************************\n");
            Console.Write("Choose your prefered operation : ");
        }

        public static void CreatePath()
        {
            Console.WriteLine(@"Enter the full path as shown (eg.: C:\Academy\place_name\place_name.txt) : ");
            Console.WriteLine("Note : place_name should be among these : Bangalore, Chennai, Mumbai, Pune");
            string full_path = Console.ReadLine();
            fs = new FileStream(full_path, FileMode.Create, FileAccess.Write);
            Console.WriteLine("File created successfully...\n");
        }

        public static void WriteFile()
        {
            sw = new StreamWriter(fs);
            Console.WriteLine("Enter the batch details :");
            sw.Write(Console.ReadLine());
            sw.Flush();
            Console.WriteLine("Data entered successfully...\n");
            fs.Close();
        }

        public static void CreateBackup()
        {
            Console.Write("Enter the full path of file to be copied : ");
            string file1 = Console.ReadLine();
           
            Console.Write("Enter the full path where you want to copy data : ");
            string file2 = Console.ReadLine();
            
            File.Copy(file1,file2);
            Console.WriteLine("File copied successfully...\n");
        }

        public static void ViewBatchDetails()
        {
            Console.Write("Enter the name of file to be viewed : ");
            string file3 = Console.ReadLine();
            fs = new FileStream(file3, FileMode.Open, FileAccess.Read);
            StreamReader br = new StreamReader(fs);
            Console.WriteLine(br.ReadToEnd());
            fs.Close();
        }

        static void Main(string[] args)
        {
            try
            {
                int choice = 0;
                do
                {
                    DisplayMenu();
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:                           
                            CreatePath();
                            break;

                        case 2:
                            WriteFile();
                            break;

                        case 3:
                            CreateBackup();
                            break;

                        case 4:
                            ViewBatchDetails();
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice!!");
                            break;
                    }
                } while (choice != 5);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("File can not be created...");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
