using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ReportService
    {
        private readonly IReportFactory _factory;

        public ReportService(IReportFactory factory)
        {
            _factory = factory;
        }

        public void CreateAndSaveReport(string rawData)
        {
            var generator = _factory.CreateGenerator();
            var formatter = _factory.CreateFormatter();
            var storage = _factory.CreateStorage();

            var report = generator.Generate(rawData);
            var formatted = formatter.Format(report);
            storage.Save(formatted);
        }
    }

}
