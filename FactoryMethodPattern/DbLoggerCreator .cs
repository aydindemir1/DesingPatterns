using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class DbLoggerCreator : LoggerCreator
    {
        public override ILogger CreateLogger()
        {
            return new DbLogger();
        }
    }
}
