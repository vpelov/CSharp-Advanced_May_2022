using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] dataIn = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string color = dataIn[0];
                string[] clothes = dataIn[1]
                        .Split(',', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        string wear = clothes[j];
                        if (!wardrobe[color].ContainsKey(wear))
                        {
                            wardrobe[color].Add(wear, 1);
                        }
                        else
                        {
                            wardrobe[color][wear]++;
                        }
                    }
                }
                else if (wardrobe.ContainsKey(color))
                {
                    for (int k = 0; k < clothes.Length; k++)
                    {
                        string wear = clothes[k];
                        if (!wardrobe[color].ContainsKey(wear))
                        {
                            wardrobe[color].Add(wear, 1);
                        }
                        else if (wardrobe[color].ContainsKey(wear))
                        {
                            wardrobe[color][wear]++;
                        }
                    }
                }
            }

            string[] searchWear = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string searchColor = searchWear[0];
            string searchClothes = searchWear[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes: ");

                foreach (var dict in item.Value)
                {
                    if (item.Key == searchColor && dict.Key == searchClothes)
                    {
                        Console.WriteLine($"* {dict.Key} - {dict.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dict.Key} - {dict.Value}");
                    }


                }
            }

            //"{color} clothes:
            //* {item1} - {count}
            //* {item2} - {count}
            //* {item3} - {count}


        }
    }
}
