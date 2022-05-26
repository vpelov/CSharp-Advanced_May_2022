using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = numbers[0];
            int m = numbers[1];

            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nSet.Add(number);
            }
            for (int j = 0; j < m; j++)
            {
                int number = int.Parse(Console.ReadLine());
                mSet.Add(number);
            }

            foreach (int number in nSet)
            {
                foreach (int num in mSet)
                {
                    if (number == num)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
        }
    }
}
