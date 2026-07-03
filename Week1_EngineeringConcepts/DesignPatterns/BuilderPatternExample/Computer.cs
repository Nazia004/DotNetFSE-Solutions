namespace BuilderPatternExample
{
    public class Computer
    {
        public string CPU { get; set; } = string.Empty;
        public string RAM { get; set; } = string.Empty;
        public string Storage { get; set; } = string.Empty;

        public void ShowConfiguration()
        {
            Console.WriteLine("Computer Configuration");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
        }
    }
}