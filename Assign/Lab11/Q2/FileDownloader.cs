using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question2
{
    public delegate void DownloadCompleteHandler(int perc);

    public class FileDownloader
    {
        protected string resourceUrl;
        protected string resourceSavePath;

        public event DownloadCompleteHandler DownLoadComplete;

        public FileDownloader(string url, string savepath)
        {
            this.resourceUrl = url;
            this.resourceSavePath = savepath;
        }

        public void DownLoadResource()
        {
            //This is just download simulation place holder code

            for (int i = 1; i <= 4; i++)
            {
                //Dummy loop to add a delay
                for (int j = 1; i <= 10000; i++) ;
                OnDownLoadComplete(i * 25);
            }

        }

        protected void OnDownLoadComplete(int n)
        {
            if (DownLoadComplete == null)
                DownLoadComplete(n);
        }
    }
}
