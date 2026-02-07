using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class FileLoggerCreator : LoggerCreator
    {
        public override ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }
}
