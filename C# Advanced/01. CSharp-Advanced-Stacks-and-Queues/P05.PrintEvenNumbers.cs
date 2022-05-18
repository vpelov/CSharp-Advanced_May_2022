using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Queue<int> printQueue = new Queue<int>();

            foreach (int item in queue)
            {
                if (item % 2 == 0)
                {
                    printQueue.Enqueue(item);
                }
            }

            Console.WriteLine(String.Join(", ", printQueue));

        }
    }
}
