using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int numberElements = data[0];
            int outElements = data[1];
            int searchNumber = data[2];

            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (int item in numbers)
            {
                stack.Push(item);
            }

            for (int i = 0; i < outElements; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (stack.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNumber = int.MaxValue;
                foreach (int item in stack)
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
