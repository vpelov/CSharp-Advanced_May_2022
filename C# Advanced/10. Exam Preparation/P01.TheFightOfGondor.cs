using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.TheFightOfGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberWaves = int.Parse(Console.ReadLine());
            Queue<int> plate = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<Stack<int>> orcArmy = new Queue<Stack<int>>();

            int count = 0;
            for (int i = 0; i < numberWaves; i++)
            {
                Stack<int> currentStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
                orcArmy.Enqueue(currentStack);
                count++;
                if (count == 3)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plate.Enqueue(newPlate);
                    count = 0;
                }
            }


            while (true)
            {
                int currentPlate = plate.Dequeue();
                Stack<int> currentOrcArmy = orcArmy.Dequeue();

                while (true)
                {
                    int orc = currentOrcArmy.Pop();
                    if (currentPlate - orc > 0)
                    {
                        currentPlate -= orc;
                    }
                    else if (currentPlate - orc == 0)
                    {
                        if (currentOrcArmy.Count != 0)
                        {
                            orcArmy.Enqueue(currentOrcArmy);
                            break;
                        }
                        break;
                    }
                    else if (currentPlate - orc < 0)
                    {
                        orc -= currentPlate;
                        currentOrcArmy.Push(orc);
                        orcArmy.Enqueue(currentOrcArmy);
                        break;
                    }
                }
                if (plate.Count == 0 || orcArmy.Count == 0)
                {
                    break;
                }
            }

            if (plate.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense");
                Console.Write("Orcs left: ");

                while(orcArmy.Count > 1)
                {
                    orcArmy.Dequeue();
                }

                Stack<int> print = orcArmy.Dequeue();
                Console.WriteLine(string.Join(", ", print));
                   
                  
            }
            else if (orcArmy.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.Write("Plates left: ");

                foreach (var item in plate)
                {
                    Console.Write($"{string.Join(", ", plate)}");

                }
            }


        }
    }
}
