using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instantiate
            FileDownloader fd = new FileDownloader("http://www.microsoft.com/vstudio/expressv10.zip",
                                                    "d:\\setups");

            //Register Event Handler
            fd.DownLoadComplete += Program.fd_DownLoadComplete;

            //Start the task...
            fd.DownLoadResource();

            Console.ReadKey();
        }

        public static void fd_DownLoadComplete(int perc)
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("Downloading  {0} Percent Complete", perc);
        }

    }
}
