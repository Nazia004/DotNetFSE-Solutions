namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("First Log Message");
            logger2.Log("Second Log Message");

            if (logger1 == logger2)
            {
                Console.WriteLine("Both logger instances are the same.");
            }
            else
            {
                Console.WriteLine("Different instances.");
            }
        }
    }
}
