using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern2
{
    public class CloudUrlGenerator : IFileUrlGenerator
    {
        public string GenerateUrl(string fileName)
        {
            return $"https://s3.aws.com/bucket/{fileName}";
        }
    }
}
