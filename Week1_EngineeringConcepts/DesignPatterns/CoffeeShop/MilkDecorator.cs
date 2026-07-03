namespace DecoratorPatternExample
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(Coffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 20;
        }
    }
}