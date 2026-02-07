using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class DbLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[DB] {message}");
        }
    }
}
