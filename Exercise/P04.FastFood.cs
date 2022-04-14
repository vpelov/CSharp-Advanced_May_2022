using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orderFood = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orderQueue = new Queue<int>();
            foreach (int item in orderFood)
            {
                orderQueue.Enqueue(item);
            }

            int biggestOrder = orderQueue.Max();

            while (quantityFood > 0 && orderQueue.Count > 0)
            {
                            
                int currentOrder = orderQueue.Peek();
                if (currentOrder > quantityFood)
                {
                    break;
                }

                if (quantityFood > currentOrder)
                {
                    quantityFood -= currentOrder;
                    orderQueue.Dequeue();
                }
            }

            Console.WriteLine(biggestOrder);

            if (orderQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(String.Join(' ', orderQueue));
            }

        }
    }
}
