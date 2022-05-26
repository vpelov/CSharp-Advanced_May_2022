using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.CitiesByContinent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataDict = new Dictionary<string, Dictionary<string, List<string>>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                string continent = data[0];
                string country = data[1];
                string city = data[2];

                if (!dataDict.ContainsKey(continent))
                {
                    var currentDict = new Dictionary<string, List<string>>();
                    var currentList = new List<string>();
                    currentList.Add(city);
                    currentDict.Add(country, currentList);
                    dataDict.Add(continent, currentDict);
                }
                else
                {
                    if (!dataDict[continent].ContainsKey(country))
                    {
                        var currentDict = new Dictionary<string, List<string>>();
                        var currentList = new List<string>();
                        currentList.Add(city);
                        //currentDict.Add(country, currentList);
                        dataDict[continent].Add(country,currentList);
                    }
                    else
                    {
                        dataDict[continent][country].Add(city);
                    }
                }
            }

            foreach (var item in dataDict)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}

