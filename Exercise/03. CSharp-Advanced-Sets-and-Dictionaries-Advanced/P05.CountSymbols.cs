using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dataDict = new Dictionary<char, int>();

            string someText = Console.ReadLine();
            char[] charArr = someText.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                char symbol = charArr[i];
                if (!dataDict.ContainsKey(symbol))
                {
                    dataDict.Add(symbol, 1);
                }
                else
                {
                    dataDict[symbol]++;
                }
            }

            var orderResult = new Dictionary<char, int>();
            orderResult = dataDict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in orderResult)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
