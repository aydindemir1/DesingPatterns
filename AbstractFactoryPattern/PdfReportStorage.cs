using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class PdfReportStorage : IReportStorage
    {
        public void Save(string formattedReport)
        {
            Console.WriteLine($"PDF saved: {formattedReport}");
        }
    }
}
