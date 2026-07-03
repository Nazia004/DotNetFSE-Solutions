using System;

namespace ReportGenerator
{
    public abstract class Report
    {
        // Template Method
        public void GenerateReport()
        {
            FetchData();
            FormatData();
            ExportReport();
        }

        protected abstract void FetchData();
        protected abstract void FormatData();
        protected abstract void ExportReport();
    }
}