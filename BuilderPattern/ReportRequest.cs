using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ReportRequest
    {
        public int PatientId { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public bool IncludeImages { get; }
        public string Language { get; }
        public string Format { get; }

        internal ReportRequest(
            int patientId,
            DateTime startDate,
            DateTime endDate,
            bool includeImages,
            string language,
            string format)
        {
            PatientId = patientId;
            StartDate = startDate;
            EndDate = endDate;
            IncludeImages = includeImages;
            Language = language;
            Format = format;
        }

        public override string ToString()
            => $"PatientId={PatientId}, Range={StartDate:yyyy-MM-dd}..{EndDate:yyyy-MM-dd}, Images={IncludeImages}, Lang={Language}, Format={Format}";
    }

}
