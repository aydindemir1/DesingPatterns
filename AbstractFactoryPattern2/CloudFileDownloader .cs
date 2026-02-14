using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class CloudFileDownloader : IFileDownloader
    {
        public void Download(string fileName)
        {
            Console.WriteLine($"Cloud download (S3): {fileName}");
        }
    }
}
