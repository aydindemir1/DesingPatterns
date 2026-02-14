using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ReportRequestBuilder
    {
        private int? _patientId;
        private DateTime? _startDate;
        private DateTime? _endDate;
        private bool _includeImages = false;    // default
        private string _language = "tr";        // default
        private string _format = "PDF";         // default

        public ReportRequestBuilder ForPatient(int patientId)
        {
            _patientId = patientId;
            return this;
        }

        public ReportRequestBuilder WithDateRange(DateTime start, DateTime end)
        {
            _startDate = start;
            _endDate = end;
            return this;
        }

        public ReportRequestBuilder IncludeImages(bool include = true)
        {
            _includeImages = include;
            return this;
        }

        public ReportRequestBuilder InLanguage(string language)
        {
            _language = language;
            return this;
        }

        public ReportRequestBuilder InFormat(string format)
        {
            _format = format;
            return this;
        }

        public ReportRequest Build()
        {
            if (_patientId is null)
                throw new InvalidOperationException("PatientId is required.");

            if (_startDate is null || _endDate is null)
                throw new InvalidOperationException("Date range is required.");

            if (_startDate > _endDate)
                throw new InvalidOperationException("StartDate cannot be after EndDate.");

            return new ReportRequest(
                _patientId.Value,
                _startDate.Value,
                _endDate.Value,
                _includeImages,
                _language,
                _format);
        }
    }

}
