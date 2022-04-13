using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.PrintEvenNumbers_withQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] inData = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            foreach (int item in inData)
            {
                if (item % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            Console.WriteLine(String.Join(", ", queue));
        }
    }
}
