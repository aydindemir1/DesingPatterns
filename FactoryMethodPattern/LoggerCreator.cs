using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class LoggerCreator
    {
        public abstract ILogger CreateLogger();

        public void Log(string message)
        {
            ILogger logger = CreateLogger();
            logger.Log(message);
        }
    }

}
