using System;

namespace ReportGenerator
{
    public class PDFReport : Report
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for PDF Report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting PDF Report...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting PDF Report.");
        }
    }
}