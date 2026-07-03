namespace ReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Report pdf = new PDFReport();
            pdf.GenerateReport();

            System.Console.WriteLine();

            Report excel = new ExcelReport();
            excel.GenerateReport();
        }
    }
}
