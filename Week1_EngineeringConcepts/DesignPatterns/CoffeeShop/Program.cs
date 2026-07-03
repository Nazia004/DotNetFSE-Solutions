using System;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new SimpleCoffee();

            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine("Cost: ₹" + coffee.GetCost());

            Console.WriteLine();

            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);

            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine("Cost: ₹" + coffee.GetCost());
        }
    }
}
