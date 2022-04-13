using System;
using System.Collections.Generic;

namespace P06.Supermarket_withQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else if (command == "Paid" && queue.Count > 0)
                {
                    for (int i = 0; i < queue.Count; )
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");

        }
    }
}
