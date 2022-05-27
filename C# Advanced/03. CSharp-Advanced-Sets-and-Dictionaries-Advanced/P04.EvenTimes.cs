using System;
using System.Collections.Generic;

namespace P04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var countDict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!countDict.ContainsKey(number))
                {
                    countDict.Add(number, 1);
                }
                else
                {
                    countDict[number]++;
                }
            }

            foreach(var evenElement in countDict)
            {
                if (evenElement.Value % 2 == 0)
                {
                    Console.WriteLine(evenElement.Key);
                }
            }
        }
    }
}
