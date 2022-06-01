using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            Action<string> print = str => Console.WriteLine(str);

            inputData.ForEach(print);
        }
    }
}
