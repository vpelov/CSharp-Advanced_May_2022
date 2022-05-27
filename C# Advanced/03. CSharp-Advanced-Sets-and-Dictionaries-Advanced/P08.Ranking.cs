using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var checkDict = new Dictionary<string, string>();
            string line = Console.ReadLine();
            while (line != "end of contests")
            {
                string[] cmd = line.Split(':').ToArray();
                string contest = cmd[0];
                string pass = cmd[1];
                checkDict.Add(contest, pass);

                line = Console.ReadLine();
            }

            var dataDict = new SortedDictionary<string, Dictionary<string, int>>();
            line = Console.ReadLine();
            while (line != "end of submissions")
            {
                string[] command = line.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string contest = command[0];
                string password = command[1];
                string userName = command[2];
                int points = int.Parse(command[3]);

                if (checkDict.ContainsKey(contest) && checkDict[contest] == password)
                {
                    if (dataDict.ContainsKey(userName) && dataDict[userName].ContainsKey(contest))
                    {
                        if (dataDict[userName][contest] < points)
                        {
                            dataDict[userName][contest] = points;
                        }
                    }
                    else if (dataDict.ContainsKey(userName) && !dataDict[userName].ContainsKey(contest))
                    {
                        dataDict[userName].Add(contest, points);
                    }
                    else if (!dataDict.ContainsKey(userName))
                    {
                        var currentDict = new Dictionary<string, int>();
                        currentDict.Add(contest, points);
                        dataDict.Add(userName, currentDict);
                    }
                }

                line = Console.ReadLine();
            }

            int bestPoint = int.MinValue;
            string bestPointName = string.Empty;

            foreach (var item in dataDict)
            {
                int pointCount = 0;
                foreach (var point in item.Value)
                {
                    pointCount += point.Value;
                }
                if (pointCount > bestPoint)
                {
                    bestPoint = pointCount;
                    bestPointName = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestPointName} with total {bestPoint} points.");
            Console.WriteLine("Ranking:");


            foreach (var name in dataDict)
            {
                Console.WriteLine(name.Key);
                foreach (var points in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }

        }
    }
}
