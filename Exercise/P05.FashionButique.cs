using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionButique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] clotesNum = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(byte.Parse)
                .ToArray();

            Stack<byte> clothesSteck = new Stack<byte>();
            foreach (byte item in clotesNum)
            {
                clothesSteck.Push(item);
            }

            byte rackCapacity = byte.Parse(Console.ReadLine());
            byte numberRack = 0;

            while (clothesSteck.Count != 0)
            {
                byte currentRack = clothesSteck.Pop();
                if (clothesSteck.Count == 0)
                {
                    numberRack++;
                    break;
                }

                while (clothesSteck.Count != 0)
                {

                    byte item = clothesSteck.Peek();
                    if (currentRack + item > rackCapacity)
                    {
                        numberRack++;
                        break;
                    }
                    else
                    {
                        currentRack += clothesSteck.Pop();
                        if (clothesSteck.Count == 0)
                        {
                            numberRack++;
                            break;
                        }
                    }
                
                }
            }

            Console.WriteLine(numberRack);
        }
    }
}
