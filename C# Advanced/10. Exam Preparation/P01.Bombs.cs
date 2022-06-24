using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Bombs
{
    class Program
    {

        private static Dictionary<int, string> infoDict = new Dictionary<int, string>()
            {
                { 40, "Datura Bombs" },
                { 60, "Cherry Bombs" },
                { 120, "Smoke Decoy Bombs" }
            };

        private static Dictionary<string, int> resultDict = new Dictionary<string, int>()
            {
                {  "Datura Bombs", 0 },
                { "Cherry Bombs", 0 },
                { "Smoke Decoy Bombs", 0 }
            };

        static void Main(string[] args)
        {
            Queue<int> bombEfects = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> casingBombs = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            bool isEnzioSuccess = false;

            while (bombEfects.Count != 0 && casingBombs.Count != 0)
            {
                if (IsFullFillPouch())
                {
                    isEnzioSuccess = true;
                    break;
                }

                int bombEfect = bombEfects.Peek();
                int casingBomb = casingBombs.Peek();
                int total = bombEfect + casingBomb;

                if (infoDict.ContainsKey(total))
                {
                    string bombName = infoDict[total];
                    resultDict[bombName]++;
                    bombEfects.Dequeue();
                    casingBombs.Pop();
                }
                else
                {
                    casingBombs.Pop();
                    casingBomb -= 5;
                    casingBombs.Push(casingBomb);
                }

            }

            Console.WriteLine(isEnzioSuccess 
                ? "Bene! You have successfully filled the bomb pouch!" 
                : "You don't have enough materials to fill the bomb pouch.");

            if (bombEfects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEfects)}");
            }

            if (casingBombs.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casingBombs)}");
            }

            foreach (var item in resultDict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        public static bool IsFullFillPouch()
        {
            if (resultDict["Datura Bombs"] >= 3 && resultDict["Cherry Bombs"] >= 3 && resultDict["Smoke Decoy Bombs"] >= 3)
            {
                return true;
            }
            return false;
        }

    }
}



