using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountSameValueInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            HashSet<string> test = new HashSet<string>();
            Dictionary<double, int> dataDict = new Dictionary<double, int>();

            for (int i = 0; i < inArray.Length; i++)
            {
                if (!dataDict.ContainsKey(inArray[i]))
                {
                    dataDict.Add(inArray[i], 1);
                }
                else
                {
                    dataDict[inArray[i]]++;
                }
            }

            foreach (var item in dataDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
