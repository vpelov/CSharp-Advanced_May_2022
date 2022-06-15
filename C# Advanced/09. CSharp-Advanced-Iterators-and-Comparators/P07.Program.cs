﻿using System;
using System.Linq;

namespace P07.CustomComarator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> comparator = (first, second) =>
            {
                if (first % 2 == 0 && second % 2 != 0)
                {
                    return -1;
                }
                else if (first % 2 != 0 && second % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return first.CompareTo(second);
                }
            };

            Array.Sort(numbers, new Comparison<int>(comparator));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
