using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           SortedSet<string> table = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string dataIn = Console.ReadLine();
                string[] elements = dataIn.Split(' ');

                for (int j = 0; j < elements.Length; j++)
                {
                    table.Add(elements[j]);
                }
            }

          
            foreach (string item in table)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
