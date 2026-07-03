namespace DecoratorPatternExample
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual string GetDescription()
        {
            return coffee.GetDescription();
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }
    }
}