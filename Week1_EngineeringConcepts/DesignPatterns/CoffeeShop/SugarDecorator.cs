namespace DecoratorPatternExample
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 10;
        }
    }
}