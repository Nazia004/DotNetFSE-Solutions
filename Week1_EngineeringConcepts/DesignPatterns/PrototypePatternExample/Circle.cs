namespace PrototypePatternExample
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }

        public override void Display()
        {
            Console.WriteLine($"Circle -> Radius: {Radius}, Color: {Color}");
        }
    }
}