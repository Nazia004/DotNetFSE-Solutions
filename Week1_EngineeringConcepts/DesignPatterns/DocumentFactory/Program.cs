namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordFactory();
            Document wordDocument = wordFactory.CreateDocument();
            wordDocument.Open();

            DocumentFactory pdfFactory = new PdfFactory();
            Document pdfDocument = pdfFactory.CreateDocument();
            pdfDocument.Open();
        }
    }
}
