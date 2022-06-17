using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steelQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> carbonStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());       

            Dictionary<string, int> swordInfo = new Dictionary<string, int>()
            {
                {"Gladius", 70 },
                { "Shamshir", 80 },
                { "Katana", 90 },
                { "Sabre", 110},
                { "Broadsword", 150 }
            };
            Dictionary<string, int> swordProduction = new Dictionary<string, int>()
            {
                {"Gladius", 0 },
                { "Shamshir", 0 },
                { "Katana", 0 },
                { "Sabre", 0},
                { "Broadsword", 0 }
            };

            int countSwords = 0;

            while (steelQueue.Count > 0 && carbonStack.Count > 0)
            {
                int steel = steelQueue.Dequeue();
                int carbon = carbonStack.Pop();
                int allMaterial = steel + carbon;

                if (swordInfo.Any(x => x.Value == allMaterial))
                {
                    string swordType = string.Empty;
                    foreach (var item in swordInfo)
                    {
                        if (item.Value == allMaterial)
                        {
                            swordType = item.Key;
                        }
                    }

                    swordProduction[swordType]++;
                    countSwords++;
                }
                else
                {
                    carbon += 5;
                    carbonStack.Push(carbon);
                }

            }

            if (swordProduction.Any(x => x.Value > 0))
            {
                Console.WriteLine($"You have forged {countSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }


            if (steelQueue.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steelQueue)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }


            if (carbonStack.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbonStack)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            foreach (var item in swordProduction.OrderBy(x => x.Key))
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }

        }
    }
}
