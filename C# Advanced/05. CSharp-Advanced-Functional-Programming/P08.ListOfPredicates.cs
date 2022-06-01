using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();
            
            for (int i = 1; i <= maxNumber; i++)
            {
                bool isPrint = true;
                foreach (var item in numbers)
                {
                    if (!func(i, item))
                    {
                        isPrint = false;
                        break;
                    }
                }

                if (isPrint)
                {
                    Console.Write(i + " ");
                }
            }       
        }
        static Func<int, int, bool> func = (x, y) => x % y == 0;        
    }
}
