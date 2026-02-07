using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FILE] {message}");
        }
    }
}
