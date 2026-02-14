using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ExcelReportStorage : IReportStorage
    {
        public void Save(string formattedReport)
        {
            Console.WriteLine($"Excel saved: {formattedReport}");
        }
    }
}
