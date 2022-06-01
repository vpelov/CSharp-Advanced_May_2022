using System;
using System.Linq;

namespace P07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> func = (x, y) => x.Length <= y;
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in names)
            {
                if (func(item, number))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
