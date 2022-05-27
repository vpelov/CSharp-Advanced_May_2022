using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var clothesDict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < number; i++)
            {
                string[] current = Console.ReadLine().Split(" -> ").ToArray();
                string[] currentClothes = current[1].Split(',').ToArray();
                string color = current[0];

                if (!clothesDict.ContainsKey(color))
                {
                    var currentDict = new Dictionary<string, int>();
                    clothesDict.Add(color, currentDict);
                    for (int j = 0; j < currentClothes.Length; j++)
                    {
                        string clothes = currentClothes[j];
                        if (!clothesDict[color].ContainsKey(clothes))
                        {
                            clothesDict[color].Add(clothes, 1);
                        }
                        else
                        {
                            clothesDict[color][clothes]++;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < currentClothes.Length; k++)
                    {
                        string clothes = currentClothes[k];
                        if (!clothesDict[color].ContainsKey(clothes))
                        {
                            clothesDict[color].Add(clothes, 1);
                        }
                        else
                        {
                            clothesDict[color][clothes]++;
                        }
                    }
                }
            }
            string[] searchClothes = Console.ReadLine().Split(' ').ToArray();
            string searchColor = searchClothes[0];
            string searchWear = searchClothes[1];

            foreach (var item in clothesDict)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var cloth in item.Value)
                {
                    if (searchColor == item.Key && searchWear == cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}


//Blue clothes:
//*dress - 1(found!)
//* jeans - 1
//* hat - 1
//* gloves - 1
//Gold clothes:
//*dress - 1
//* t - shirt - 1
//* boxers - 1
//White clothes:
//*briefs - 1
//* tanktop - 1
