using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BakeryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> waterQueue = new Queue<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());
            Stack<double> flourStack = new Stack<double>(Console.ReadLine().Split().Select(double.Parse).ToArray());
            Dictionary<string, int> bakery = new Dictionary<string, int>();

            bool isWater = true;
            bool isFlour = true;

            while (waterQueue.Count != 0 && flourStack.Count != 0)
            {
                double water = waterQueue.Dequeue();
                double flour = flourStack.Pop();

                if (water == (flour + water) * 0.5)
                {
                    if (!bakery.ContainsKey("Croissant"))
                    {
                        bakery.Add("Croissant", 1);
                    }
                    else
                    {
                        bakery["Croissant"]++;
                    }
                }
                else if (water == (flour + water) * 0.4)
                {
                    if (!bakery.ContainsKey("Muffin"))
                    {
                        bakery.Add("Muffin", 1);
                    }
                    else
                    {
                        bakery["Muffin"]++;
                    }
                }
                else if (water == (flour + water) * 0.3)
                {
                    if (!bakery.ContainsKey("Baguette"))
                    {
                        bakery.Add("Baguette", 1);
                    }
                    else
                    {
                        bakery["Baguette"]++;
                    }
                }
                else if (water == (flour + water) * 0.2)
                {
                    if (!bakery.ContainsKey("Bagel"))
                    {
                        bakery.Add("Bagel", 1);
                    }
                    else
                    {
                        bakery["Bagel"]++;
                    }
                }
                else
                {
                    if (water > flour)
                    {
                        if (!bakery.ContainsKey("Croissant"))
                        {
                            bakery.Add("Croissant", 1);
                        }
                        else
                        {
                            bakery["Croissant"]++;
                        }
                    }
                    else
                    {
                        if (!bakery.ContainsKey("Croissant"))
                        {
                            bakery.Add("Croissant", 1);
                        }
                        else
                        {
                            bakery["Croissant"]++;
                        }
                        flour -= water;
                        flourStack.Push(flour);
                    }
                }

                if (waterQueue.Count == 0)
                {
                    isWater = false;
                }
                if (flourStack.Count == 0)
                {
                    isFlour = false;
                }

            }

            foreach (var item in bakery.OrderByDescending(x => x.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
                        
            Console.WriteLine(isWater ? $"Water left: {string.Join(", ", waterQueue)}" : "Water left: None");
            Console.WriteLine(isFlour ? $"Flour left: {string.Join(", ", flourStack)}" : "Flour left: None");
        }
    }
}
