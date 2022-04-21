using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dataLogger = new Dictionary<string, List<string>>();

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
                        dataLogger.Add(vloggerName, new List<string>());
                    }
                }
                else if (cmd[1] == "followed")
                {
                    string folloed = cmd[0];
                    string vloggerName = cmd[2];
                    if (dataLogger.ContainsKey(folloed) && dataLogger.ContainsKey(vloggerName) && folloed != vloggerName)
                    {
                        if (!dataLogger[vloggerName].Contains(folloed))
                        {
                            dataLogger[vloggerName].Add(folloed);
                        }
                    }

                }

            }

            Console.WriteLine($"The V-Logger has a total of {dataLogger.Count} vloggers in its logs.");

            int maxFollowers = int.MinValue;
            string name = string.Empty;

            foreach (var item in dataLogger)
            {
                int current = item.Value.Count;
                if (current > maxFollowers)
                {
                    name = item.Key;
                }
            }


                        // TODO................!!!!!



        }
    }
}
