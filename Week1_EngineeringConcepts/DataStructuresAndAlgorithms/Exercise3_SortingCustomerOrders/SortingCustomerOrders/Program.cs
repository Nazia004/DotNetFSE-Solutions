using System;

namespace SortingCustomerOrders
{
    class Program
    {
        static void DisplayOrders(Order[] orders)
        {
            foreach (Order order in orders)
            {
                Console.WriteLine(order);
            }
        }

        static void Main(string[] args)
        {
            Order[] bubbleOrders =
            {
                new Order(1,"Nazia",2500),
                new Order(2,"Rahul",1200),
                new Order(3,"Anjali",4000),
                new Order(4,"Aman",1800)
            };

            Console.WriteLine("Orders Before Bubble Sort\n");

            DisplayOrders(bubbleOrders);

            SortService.BubbleSort(bubbleOrders);

            Console.WriteLine("\nOrders After Bubble Sort\n");

            DisplayOrders(bubbleOrders);

            Console.WriteLine("\n--------------------------\n");

            Order[] quickOrders =
            {
                new Order(1,"Nazia",2500),
                new Order(2,"Rahul",1200),
                new Order(3,"Anjali",4000),
                new Order(4,"Aman",1800)
            };

            Console.WriteLine("Orders Before Quick Sort\n");

            DisplayOrders(quickOrders);

            SortService.QuickSort(quickOrders, 0, quickOrders.Length - 1);

            Console.WriteLine("\nOrders After Quick Sort\n");

            DisplayOrders(quickOrders);
        }
    }
}
