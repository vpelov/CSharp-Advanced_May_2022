using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<List<string>>> dataLogger = new Dictionary<string, List<List<string>>>();


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Statistics")
                {
                    break;
                }

                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmd[1] == "joined")
                {
                    string vloggerName = cmd[0];
                    if (!dataLogger.ContainsKey(vloggerName))
                    {
                        List<List<string>> data = new List<List<string>>();
                        List<string> primeList = new List<string>();
                        List<string> followedList = new List<string>();
                        data.Add(primeList);
                        data.Add(followedList);
                        dataLogger.Add(vloggerName, data);
                    }
                }
                else if (cmd[1] == "followed")
                {
                    string folloer = cmd[0];
                    string prime = cmd[2];
                    if (dataLogger.ContainsKey(folloer) && dataLogger.ContainsKey(prime) && folloer != prime)
                    {
                        if (!dataLogger[prime][0].Contains(folloer))
                        {
                            dataLogger[prime][0].Add(folloer);
                            dataLogger[folloer][1].Add(prime);
                        }
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {dataLogger.Count} vloggers in its logs.");

            string famousVlogger = string.Empty;
            int followers = int.MinValue;

            foreach (var item in dataLogger)
            {
                if (item.Value[0].Count > followers)
                {
                    followers = item.Value[0].Count;
                    famousVlogger = item.Key;
                    continue;
                }

                if (item.Value[0].Count == followers)
                {
                    if (item.Value[1].Count < dataLogger[famousVlogger][1].Count)
                    {
                        famousVlogger = item.Key;
                    }
                }
            }

            int countNumber = 1;

            foreach (var item in dataLogger)
            {

                if (item.Key == famousVlogger)
                {
                    Console.WriteLine($"{countNumber}. {famousVlogger} : {item.Value[0].Count} followers, {item.Value[1].Count} following");
                    countNumber++;
                    foreach (string data in item.Value[0].OrderBy(x => x))
                    {                        
                        Console.WriteLine($"*  {data}");
                    }
                }
            }

            foreach (var item in dataLogger.OrderByDescending(x => x.Value[0].Count).ThenBy(x => x.Value[1].Count))
            {
                if (item.Key != famousVlogger)
                {
                    Console.WriteLine($"{countNumber}. {item.Key} : {item.Value[0].Count} followers, {item.Value[1].Count} following");
                    countNumber++;
                }
            }
        }
    }
}