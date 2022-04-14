using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] query = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int command = query[0];

                if (command == 1)
                {
                    int num = query[1];
                    stack.Push(num);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine($"{stack.Max()}");
                }
                else if (command == 4 && stack.Count > 0)
                {
                    Console.WriteLine($"{stack.Min()}");
                }
            }

            Console.WriteLine(String.Join(", ", stack));

        }
    }
}
