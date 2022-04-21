using System;
using System.Collections.Generic;

namespace P01.UniqueUsername
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dataUserName = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                dataUserName.Add(name); 
            }

            foreach (string item in dataUserName)
            {
                Console.WriteLine(item);
            }

        }
    }
}
