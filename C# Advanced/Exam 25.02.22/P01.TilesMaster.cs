using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.TilesMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whites = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> grays = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Dictionary<int, string> infoDict = new Dictionary<int, string>()
            {
                { 40, "Sink"},
                {  50, "Oven"},
                {  60, "Countertop"},
                {  70, "Wall"}
            };

            Dictionary<string, int> resultDict = new Dictionary<string, int>()
            {
                {  "Sink", 0},
                {   "Oven", 0 },
                {  "Countertop", 0},
                {  "Wall", 0}
            };

            int countFloor = 0;


            while (whites.Count != 0 && grays.Count != 0)
            {
                int white = whites.Peek();
                int grey = grays.Peek();

                if (white == grey)
                {
                    int total = white + grey;
                    if (infoDict.ContainsKey(total))
                    {
                        string place = infoDict[total];
                        if (resultDict.ContainsKey(place))
                        {
                            resultDict[place]++;
                        }

                    }
                    else
                    {
                        countFloor++;

                    }

                    whites.Pop();
                    grays.Dequeue();
                }
                else
                {
                    int currentWhite = whites.Pop();
                    int x = currentWhite / 2;
                    whites.Push(x);
                    int y = grays.Dequeue();
                    grays.Enqueue(y);
                }

            }

            if (whites.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whites)}");
            }

            if (grays.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grays)}");
            }

            resultDict.Add("Floor", countFloor);

            foreach (var item in resultDict.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                if (item.Value != 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");

                }
            }
        }
    }
}
