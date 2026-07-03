using System;

namespace ReportGenerator
{
    public class ExcelReport : Report
    {
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for Excel Report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting Excel Report...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting Excel Report.");
        }
    }
}