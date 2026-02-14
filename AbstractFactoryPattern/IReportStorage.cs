using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IReportStorage
    {
        void Save(string formattedReport);
    }
}
