using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var chemicalCollection = new HashSet<string>();
            for (int i = 0; i < number; i++)
            {
                string[] currentString = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                for (int j = 0; j < currentString.Length; j++)
                {
                    string current = currentString[j];
                    chemicalCollection.Add(current);
                }
            }

            var printCollection = chemicalCollection.OrderBy(x => x);

            foreach (string elements in printCollection)
            {
                Console.Write($"{elements} ");
            }
        }
    }
}
