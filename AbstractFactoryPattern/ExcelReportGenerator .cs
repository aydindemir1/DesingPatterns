using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ExcelReportGenerator : IReportGenerator
    {
        public string Generate(string rawData)
            => $"EXCEL_REPORT_CONTENT({rawData})";
    }
}
