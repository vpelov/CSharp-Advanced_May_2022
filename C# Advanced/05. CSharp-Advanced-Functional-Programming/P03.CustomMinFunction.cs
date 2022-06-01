using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> getMinNum = num => num.Min();

            Console.WriteLine(getMinNum(numbers));
        }
    }
}
