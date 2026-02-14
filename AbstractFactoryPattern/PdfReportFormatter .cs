using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(string reportContent)
            => $"[PDF_FORMATTED] {reportContent}";
    }
}
