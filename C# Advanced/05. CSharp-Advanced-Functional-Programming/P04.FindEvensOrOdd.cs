using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FindEvensOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int startNum = numbers[0];
            int endNum = numbers[1];
            string type = Console.ReadLine();

            Predicate<int> isOdd = x => x % 2 != 0;
            Predicate<int> isEven = x => x % 2 == 0;

            if (type == "even")
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (isEven(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else if (type == "odd")
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (isOdd(i))
                    {
                        Console.Write(i + " ");
                    }
                }
            }        
        }
    }
}
