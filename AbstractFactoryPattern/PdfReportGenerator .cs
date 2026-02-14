using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class PdfReportGenerator : IReportGenerator
    {
        public string Generate(string rawData)
            => $"PDF_REPORT_CONTENT({rawData})";
    }
}
