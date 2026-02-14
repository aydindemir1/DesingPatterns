using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ReportDirector
    {
        public ReportRequest CreateStandardReport(int patientId)
        {
            return new ReportRequestBuilder()
                .ForPatient(patientId)
                .WithDateRange(DateTime.Today.AddDays(-7), DateTime.Today)
                .InFormat("PDF")
                .Build();
        }

        public ReportRequest CreateDetailedReport(int patientId)
        {
            return new ReportRequestBuilder()
                .ForPatient(patientId)
                .WithDateRange(DateTime.Today.AddMonths(-1), DateTime.Today)
                .IncludeImages()
                .InLanguage("en")
                .InFormat("PDF")
                .Build();
        }

        public ReportRequest CreateAuditReport(int patientId)
        {
            return new ReportRequestBuilder()
                .ForPatient(patientId)
                .WithDateRange(DateTime.Today.AddYears(-1), DateTime.Today)
                .IncludeImages()
                .InLanguage("tr")
                .InFormat("EXCEL")
                .Build();
        }
    }

}
