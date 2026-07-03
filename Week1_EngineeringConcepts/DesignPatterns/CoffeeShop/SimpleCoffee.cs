namespace DecoratorPatternExample
{
    public class SimpleCoffee : Coffee
    {
        public string GetDescription()
        {
            return "Plain Coffee";
        }

        public double GetCost()
        {
            return 50;
        }
    }
}