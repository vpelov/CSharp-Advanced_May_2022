using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            int[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberQueue = command[0];
            int removeNumber = command[1];
            int searchNumber = command[2];

            int[] numbersArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (int item in numbersArray)
            {
                queue.Enqueue(item);
            }

            for (int i = 0; i < removeNumber; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNumber = int.MaxValue;
                foreach (int item in queue)
                {
                    if (item < minNumber)
                    {
                        minNumber = item;
                    }
                }
                    Console.WriteLine(minNumber);
            }
        }
    }
}
