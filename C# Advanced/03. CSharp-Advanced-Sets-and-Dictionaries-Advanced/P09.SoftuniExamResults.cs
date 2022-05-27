using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.SoftuniExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentNameAndPoints = new Dictionary<string, int>();
            var studentLanguage = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "exam finished")
                {
                    break;
                }

                string[] command = line.Split('-').ToArray();
                string userName = command[0];
                string language = command[1];

                if (language == "banned" && studentNameAndPoints.ContainsKey(userName))
                {
                    studentNameAndPoints.Remove(userName);
                    continue;
                }

                int points = int.Parse(command[2]);

                if (studentNameAndPoints.ContainsKey(userName) && points > studentNameAndPoints[userName])
                {
                    studentNameAndPoints[userName] = points;
                }
                else if (!studentNameAndPoints.ContainsKey(userName))
                {
                    studentNameAndPoints.Add(userName, points);
                }

                if (!studentLanguage.ContainsKey(language))
                {
                    studentLanguage.Add(language, 1);
                }
                else
                {
                    studentLanguage[language]++;
                }


            }

            Console.WriteLine("Results:");
            foreach (var item in studentNameAndPoints.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in studentLanguage.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
