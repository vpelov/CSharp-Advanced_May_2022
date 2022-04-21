using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, List<string>>> crazyDict = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] dataIn = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = dataIn[0];
                string country = dataIn[1];
                string city = dataIn[2];

                if (!crazyDict.ContainsKey(continent))
                {
                    crazyDict.Add(continent, new Dictionary<string, List<string>>());
                    crazyDict[continent].Add(country, new List<string>());
                    crazyDict[continent][country].Add(city);
                }
                else
                {
                    if (!crazyDict[continent].ContainsKey(country))
                    {
                        crazyDict[continent].Add(country, new List<string>());
                        crazyDict[continent][country].Add(city);
                    }
                    else
                    {
                        crazyDict[continent][country].Add(city);
                    }
                }
            }

            foreach (var item in crazyDict)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var data in item.Value)
                {
                    Console.Write($"{data.Key} -> ");
                    Console.WriteLine($"{string.Join(", ", data.Value)}");
                }
            }


        }
    }
}
