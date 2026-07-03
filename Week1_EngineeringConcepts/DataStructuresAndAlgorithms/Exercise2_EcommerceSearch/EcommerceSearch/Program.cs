using System;

namespace EcommerceSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101,"Headphones","Electronics"),
                new Product(102,"Keyboard","Electronics"),
                new Product(103,"Laptop","Electronics"),
                new Product(104,"Mouse","Electronics"),
                new Product(105,"Smartphone","Electronics")
            };

            Console.WriteLine("===== Linear Search =====");

            Product? linearResult =
                SearchService.LinearSearch(products, "Laptop");

            if (linearResult != null)
                Console.WriteLine(linearResult);
            else
                Console.WriteLine("Product not found.");

            Console.WriteLine();

            Console.WriteLine("===== Binary Search =====");

            Product? binaryResult =
                SearchService.BinarySearch(products, "Laptop");

            if (binaryResult != null)
                Console.WriteLine(binaryResult);
            else
                Console.WriteLine("Product not found.");
        }
    }
}
