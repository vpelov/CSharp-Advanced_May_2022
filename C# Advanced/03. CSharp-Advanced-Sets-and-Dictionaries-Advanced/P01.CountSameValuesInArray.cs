using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] digits = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> countDict = new Dictionary<double, int>();

            for (int i = 0; i < digits.Length; i++)
            {
                double num = digits[i];

                if (!countDict.ContainsKey(num))
                {
                    countDict[num] = 1;
                }
                else
                {
                    countDict[num]++;
                }
            }
            foreach (var item in countDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
