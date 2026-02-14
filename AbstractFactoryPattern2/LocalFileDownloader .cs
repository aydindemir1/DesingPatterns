using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class LocalFileDownloader : IFileDownloader
    {
        public void Download(string fileName)
        {
            Console.WriteLine($"Local download: {fileName}");
        }
    }
}
