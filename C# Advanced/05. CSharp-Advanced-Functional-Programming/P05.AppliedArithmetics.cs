using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x * 2;
            Func<int, int> substract = x => x - 1;
            Action<int> printElement = x => Console.Write(x + " ");

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(add).ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(substract).ToList();
                }
                else if (command == "print")
                {
                    numbers.ForEach(printElement);
                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }           
        }        
    }
}
