using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataDict = new Dictionary<string, Dictionary<string, double>>();

            string data = Console.ReadLine();
            while (true)
            {
                if (data == "Revision")
                {
                    break;
                }

                string[] cmd = data.Split(", ");

                string market = cmd[0];
                string product = cmd[1];
                double price = double.Parse(cmd[2]);

                if (!dataDict.ContainsKey(market))
                {
                    dataDict.Add(market, new Dictionary<string, double>());
                    dataDict[market].Add(product, price);
                }
                else
                {
                    dataDict[market].Add(product, price);
                }
                data = Console.ReadLine();
            }

            //Dictionary<string, Dictionary<string, double>> printDict = new Dictionary<string, Dictionary<string, double>>();

            var printDict = dataDict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var market in printDict)
            {
                Console.WriteLine($"{market.Key}->");

                foreach (var item in market.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }

        }
    }
}

