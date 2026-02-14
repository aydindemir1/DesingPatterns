using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IReportFactory
    {
        IReportGenerator CreateGenerator();
        IReportFormatter CreateFormatter();
        IReportStorage CreateStorage();
    }

}
