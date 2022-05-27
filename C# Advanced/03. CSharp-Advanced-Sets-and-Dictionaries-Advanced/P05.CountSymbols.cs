using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var countDict = new Dictionary<char, int>();
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                char currentChar = charArray[i];
                if (!countDict.ContainsKey(currentChar))
                {
                    countDict.Add(currentChar, 1);
                }
                else
                {
                    countDict[currentChar]++;
                }
            }

            var printDict = countDict.OrderBy(x => x.Key);
            foreach (var chars in printDict)
            {
                Console.WriteLine($"{chars.Key}: {chars.Value} time/s");
            }
        }
    }
}
//S: 1 time / s