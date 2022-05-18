using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inData = Console.ReadLine();
            int numberCircle = int.Parse(Console.ReadLine());

            string[] data = inData
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> queue = new Queue<string>();

            foreach (string item in data)
            {
                queue.Enqueue(item);
            }

            while (queue.Count > 1)
            {
                for (int i = 0; i < numberCircle - 1; i++)
                {
                    string remove = queue.Dequeue();
                    queue.Enqueue(remove);
                }

                string print = queue.Dequeue();
                Console.WriteLine($"Removed {print}");
            }

            string last = queue.Peek();
            Console.WriteLine($"Last is {last}");

        }
    }
}
