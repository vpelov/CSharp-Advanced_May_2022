using System;
using System.Linq;
using System.Collections.Generic;

namespace P07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputDataName = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>();
            foreach (string item in inputDataName)
            {
                kids.Enqueue(item);
            }

            while (kids.Count > 1)
            {

                for (int i = 0; i < number - 1; i++)
                {
                    string potato = kids.Dequeue();
                    kids.Enqueue(potato);
                }

                string removeKids = kids.Dequeue();
                Console.WriteLine($"Removed {removeKids}");
            }

            string lastKid = kids.Peek();
            Console.WriteLine($"Last is {lastKid}");
        }
    }
}
