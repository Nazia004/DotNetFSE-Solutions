namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            GamingComputerBuilder builder = new GamingComputerBuilder();

            director.Construct(builder);

            Computer computer = builder.GetComputer();

            computer.ShowConfiguration();
        }
    }
}
