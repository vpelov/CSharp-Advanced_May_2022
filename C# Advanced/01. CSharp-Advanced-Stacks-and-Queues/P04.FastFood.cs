using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityAllFood = int.Parse(Console.ReadLine());
            int[] orderSequence = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orderQueue = new Queue<int>();
            foreach (int item in orderSequence)
            {
                orderQueue.Enqueue(item);
            }
            Console.WriteLine(orderQueue.Max());

            while (orderQueue.Count > 0)
            {
                int currentNumber = orderQueue.Peek();
                if (currentNumber <= quantityAllFood)
                {
                    quantityAllFood -= currentNumber;
                    orderQueue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orderQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orderQueue)}");
            }
        }
    }
}
