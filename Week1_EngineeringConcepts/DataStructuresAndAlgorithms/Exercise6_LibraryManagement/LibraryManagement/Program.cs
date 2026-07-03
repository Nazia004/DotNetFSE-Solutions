using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books =
            {
                new Book(101,"C Programming","Dennis Ritchie"),
                new Book(102,"Computer Networks","Andrew Tanenbaum"),
                new Book(103,"Data Structures","Seymour Lipschutz"),
                new Book(104,"Operating Systems","Galvin"),
                new Book(105,"Python Programming","Guido van Rossum")
            };

            Console.WriteLine("===== Linear Search =====");

            Book? linearBook = LibrarySearch.LinearSearch(books, "Operating Systems");

            if (linearBook != null)
                Console.WriteLine(linearBook);
            else
                Console.WriteLine("Book not found.");

            Console.WriteLine();

            Console.WriteLine("===== Binary Search =====");

            Book? binaryBook = LibrarySearch.BinarySearch(books, "Operating Systems");

            if (binaryBook != null)
                Console.WriteLine(binaryBook);
            else
                Console.WriteLine("Book not found.");
        }
    }
}
