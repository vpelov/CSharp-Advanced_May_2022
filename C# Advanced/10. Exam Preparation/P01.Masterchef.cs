using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> freshLevels = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<string, int> infoDict = new Dictionary<string, int>()
            {
                { "Dipping sauce", 150 },
                {"Green salad", 250  },
                {"Chocolate cake", 300},
                { "Lobster", 400 }
            };
            Dictionary<string, int> resultDict = new Dictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                {"Green salad", 0  },
                {"Chocolate cake", 0},
                { "Lobster", 0 }
            };
            while (ingredients.Count != 0 && freshLevels.Count != 0)
            {             
                int ingradient = ingredients.Peek();
                if (ingradient == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int freshLevel = freshLevels.Peek();
                int total = ingradient * freshLevel;

                if (infoDict.Any(x => x.Value == total))
                {
                    string product = string.Empty;
                    foreach (var item in infoDict)
                    {
                        if (item.Value == total)
                        {
                            product = item.Key;
                        }
                    }

                    if (!resultDict.ContainsKey(product))
                    {
                        resultDict.Add(product, 1);
                    }
                    else
                    {
                        resultDict[product]++;
                    }
                    ingredients.Dequeue();
                    freshLevels.Pop();
                }
                else
                {
                    freshLevels.Pop();
                    int ring = ingredients.Dequeue();
                    ingredients.Enqueue(ring + 5);
                }
            }

            bool isSuccess = true;
            foreach (var item in resultDict)
            {
                if (item.Value == 0)
                {
                    isSuccess = false;
                }
            }

            Console.WriteLine(isSuccess ? "Applause! The judges are fascinated by your dishes!" : "You were voted off. Better luck next year.");

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }            

            foreach (var item in resultDict.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($" # {item.Key} --> {item.Value}");
            }

        }
    }
}

