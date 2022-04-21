using System;
using System.Collections.Generic;

namespace P05.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> namesStore = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                namesStore.Add(name);
            }

            foreach (string item in namesStore)
            {
                Console.WriteLine(item);
            }
        }
    }
}
