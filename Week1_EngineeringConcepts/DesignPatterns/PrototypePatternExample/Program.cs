namespace PrototypePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle
            {
                Radius = 10,
                Color = "Red"
            };

            Circle clonedCircle = (Circle)circle.Clone();

            Rectangle rectangle = new Rectangle
            {
                Width = 20,
                Height = 10,
                Color = "Blue"
            };

            Rectangle clonedRectangle = (Rectangle)rectangle.Clone();

            Console.WriteLine("Original Objects");
            circle.Display();
            rectangle.Display();

            Console.WriteLine();

            Console.WriteLine("Cloned Objects");
            clonedCircle.Display();
            clonedRectangle.Display();
        }
    }
}