using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class LocalUrlGenerator : IFileUrlGenerator
    {
        public string GenerateUrl(string fileName)
        {
            return $"http://localhost/files/{fileName}";
        }
    }
}
