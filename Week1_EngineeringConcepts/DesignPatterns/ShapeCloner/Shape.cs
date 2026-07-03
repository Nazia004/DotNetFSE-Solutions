namespace PrototypePatternExample
{
    public abstract class Shape
    {
        public string Color { get; set; } = string.Empty;

        public abstract Shape Clone();

        public abstract void Display();
    }
}