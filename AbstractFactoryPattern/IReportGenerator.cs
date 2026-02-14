using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IReportGenerator
    {
        string Generate(string rawData);
    }
}
