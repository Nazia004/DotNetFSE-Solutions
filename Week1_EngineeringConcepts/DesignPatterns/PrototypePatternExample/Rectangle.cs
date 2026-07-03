namespace PrototypePatternExample
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle -> Width: {Width}, Height: {Height}, Color: {Color}");
        }
    }
}