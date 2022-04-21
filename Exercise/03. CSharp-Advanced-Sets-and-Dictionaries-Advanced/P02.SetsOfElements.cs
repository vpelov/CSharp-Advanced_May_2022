using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] lengthSets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = lengthSets[0];
            int m = lengthSets[1];

            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondSet = new HashSet<string>();
            HashSet<string> print = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                firstSet.Add(element);
            }
            for (int i = 0; i < m; i++)
            {
                string element = Console.ReadLine();
                secondSet.Add(element);
            }

            foreach (string item in firstSet)
            {
                foreach (string data in secondSet)
                {
                    if (item == data)
                    {
                        Console.Write($"{item} ");
                    }
                }
            }


        }
    }
}
