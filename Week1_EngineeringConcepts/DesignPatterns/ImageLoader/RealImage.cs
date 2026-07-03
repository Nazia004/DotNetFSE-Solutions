using System;

namespace ImageLoader
{
    public class RealImage : IImage
    {
        private readonly string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {fileName}...");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {fileName}");
        }
    }
}