using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class PdfReportFactory : IReportFactory
    {
        public IReportGenerator CreateGenerator() => new PdfReportGenerator();
        public IReportFormatter CreateFormatter() => new PdfReportFormatter();
        public IReportStorage CreateStorage() => new PdfReportStorage();
    }
}
