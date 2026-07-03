using System;

namespace ImageLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("profile_photo.jpg");

            Console.WriteLine("Image created.");
            Console.WriteLine();

            Console.WriteLine("First Display:");
            image.Display();

            Console.WriteLine();

            Console.WriteLine("Second Display:");
            image.Display();
        }
    }
}
