using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IReportFormatter
    {
        string Format(string reportContent);
    }
}
