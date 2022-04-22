using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[][]> dataLogger = new Dictionary<string, string[][]>();

            
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
                        string[][] data = new string[2][];
                        dataLogger.Add(vloggerName, data);
                    }
                }
                else if (cmd[1] == "followed")
                {
                    string folloed = cmd[0];
                    string member = cmd[2];
                    if (dataLogger.ContainsKey(folloed) && dataLogger.ContainsKey(member) && folloed != member)
                    {
                        if (!dataLogger[folloed][0].Contains(member))
                        {
                            dataLogger[folloed][0].Append(member);
                            dataLogger[folloed][1].Append(folloed);
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
