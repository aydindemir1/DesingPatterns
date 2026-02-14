using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class CloudFileUploader : IFileUploader
    {
        public void Upload(string fileName)
        {
            Console.WriteLine($"Cloud upload (S3): {fileName}");
        }
    }
}
