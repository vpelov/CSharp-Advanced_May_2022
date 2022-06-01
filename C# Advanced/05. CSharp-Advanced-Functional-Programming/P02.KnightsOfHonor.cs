using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> inputData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Action<string> addAndPrint = str => Console.WriteLine("Sir " + str);

            inputData.ForEach(addAndPrint);           
        }
    }
}
