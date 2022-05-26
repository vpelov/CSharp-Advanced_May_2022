using System;
using System.Collections.Generic;

namespace P01.UniqueUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userNames = new HashSet<string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                userNames.Add(name);
            }
            Console.WriteLine();
            foreach (var item in userNames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
