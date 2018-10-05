using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class File
    {
        static void Main(string[] args)
        {
            try
            {
                //Get the file name to be assigned to a file from the user
                Console.WriteLine("Enter the file name : ");
                string File_name = Console.ReadLine();
               //Create the file with the recieved file_name
                FileStream fs = new FileStream(File_name, FileMode.Create, FileAccess.Write);
                //Writing over the created file..
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter the data to be uploaded\n");
                sw.Write(Console.ReadLine());
                sw.Flush();
                fs.Close();

                //Open and read the created file
                fs = new FileStream(File_name, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("\nThe Data entered by the user in the file is :");
                Console.WriteLine(sr.ReadToEnd());
                //Console.WriteLine(sr.Read());
                //Console.WriteLine(sr.Read());
                //Console.WriteLine(sr.Read());

                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("The created file  does not exist\n");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
