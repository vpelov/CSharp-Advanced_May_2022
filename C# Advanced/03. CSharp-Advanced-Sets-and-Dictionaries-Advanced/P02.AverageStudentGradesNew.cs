using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.AverageStudentGradesNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> dataDict = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] stringArr = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                string name = stringArr[0];
                decimal grade = decimal.Parse(stringArr[1]);
                if (!dataDict.ContainsKey(name))
                {
                    List<decimal> current = new List<decimal>();
                    current.Add(grade);
                    dataDict.Add(name, current);
                }
                else
                {
                    dataDict[name].Add(grade);
                }
            }

            foreach (var item in dataDict)
            {
                Console.Write($"{item.Key} -> ");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.Write($"{item.Value[i]:f2} ");
                }
                Console.WriteLine($"(avg: { item.Value.Average():f2})");

            }
        }
    }
}
