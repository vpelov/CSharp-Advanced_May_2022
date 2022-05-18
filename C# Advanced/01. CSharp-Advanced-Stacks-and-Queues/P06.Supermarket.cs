using System;
using System.Collections.Generic;

namespace P06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        string printString = queue.Dequeue();
                        Console.WriteLine(printString);
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");


        }
    }
}
