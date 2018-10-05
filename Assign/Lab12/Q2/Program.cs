using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileShift
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the source file name");
            string source_file = Console.ReadLine();

            //Create the content for the source_file
            FileStream fs = new FileStream(source_file, FileMode.Create, FileAccess.Write);
            //Writing over the created file..
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the data to be uploaded\n");
            sw.Write(Console.ReadLine());
            sw.Flush();
            fs.Close();

            Console.WriteLine("Enter the destination filename");
            string dest_file = Console.ReadLine();

            //The contents available in the source file Copied to the destination file...
            System.IO.File.Copy(source_file, dest_file);

            //dest_file = File.ReadAllText(source_file);


        }
    }
}
