using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(string reportContent)
            => $"[EXCEL_FORMATTED] {reportContent}";
    }
}
