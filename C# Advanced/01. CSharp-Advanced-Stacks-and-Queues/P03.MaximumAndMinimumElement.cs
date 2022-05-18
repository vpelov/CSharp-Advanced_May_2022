using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int numberOperation = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOperation; i++)
            {
                int[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    int maxNumber = stack.Max();
                    Console.WriteLine(maxNumber);
                }
                else if (command[0] == 4)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
