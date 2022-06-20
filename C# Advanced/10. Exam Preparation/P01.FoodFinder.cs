using System;
using System.Collections.Generic;

namespace P01.FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Replace(" ", string.Empty).ToCharArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Replace(" ", string.Empty).ToCharArray());

            Dictionary<string, HashSet<char>> harvestDict = new Dictionary<string, HashSet<char>>()
            {
                { "pear", new HashSet<char>()},
                { "flour", new HashSet<char>()},
                { "pork", new HashSet<char>()},
                { "olive", new HashSet<char>()}
            };

            while (true)
            {
                if (consonants.Count == 0)
                {
                    break;
                }

                char currentVowel = vowels.Dequeue();
                char currentConsonant = consonants.Pop();

                foreach (var item in harvestDict)
                {
                    char[] charArr = item.Key.ToCharArray();
                    foreach (char ch in charArr)
                    {
                        if (currentVowel == ch)
                        {
                            harvestDict[item.Key].Add(ch);
                        }

                        if (currentConsonant == ch)
                        {
                            harvestDict[item.Key].Add(ch);
                        }
                    }
                }

                vowels.Enqueue(currentVowel);
            }

            int numberWords = 0;
            foreach (var item in harvestDict)
            {
                int keyCount = item.Key.Length;
                if (keyCount == item.Value.Count)
                {
                    numberWords++;
                }
            }

            Console.WriteLine($"Words found: {numberWords}");

            foreach (var item in harvestDict)
            {
                int keyCount = item.Key.Length;
                if (keyCount == item.Value.Count)
                {
                    Console.WriteLine(item.Key);
                }
            }


        }
    }
}
