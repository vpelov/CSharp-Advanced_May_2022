using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shopDict = new Dictionary<string, Dictionary<string, double>>();
            string line = Console.ReadLine();
            while (line != "Revision")
            {
                string[] command = line.Split(", ").ToArray();
                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!shopDict.ContainsKey(shop))
                {
                    Dictionary<string, double> productDict = new Dictionary<string, double>();
                    productDict.Add(product, price);
                    shopDict.Add(shop, productDict);
                }
                else
                {
                    if (!shopDict[shop].ContainsKey(product))
                    {
                        shopDict[shop].Add(product, price);
                    }
                    else
                    {
                        shopDict[shop][product] = price;
                    }
                }

                line = Console.ReadLine();
            }
            var printDict = shopDict.OrderBy(x => x.Key);

            foreach (var shop in printDict)
            {
                Console.WriteLine($"{shop.Key}-> ");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }

        //Product: apple, Price: 1.2
        }
    }
}
