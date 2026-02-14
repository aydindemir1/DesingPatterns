using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class LocalFileUploader : IFileUploader
    {
        public void Upload(string fileName)
        {
            Console.WriteLine($"Local upload: {fileName}");
        }
    }
}
