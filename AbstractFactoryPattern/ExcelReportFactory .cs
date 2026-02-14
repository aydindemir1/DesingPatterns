using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ExcelReportFactory : IReportFactory
    {
        public IReportGenerator CreateGenerator() => new ExcelReportGenerator();
        public IReportFormatter CreateFormatter() => new ExcelReportFormatter();
        public IReportStorage CreateStorage() => new ExcelReportStorage();
    }
}
