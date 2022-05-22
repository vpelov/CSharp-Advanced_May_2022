using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionButique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValue = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < clothesValue.Length; i++)
            {
                stack.Push(clothesValue[i]);
            }

            int rackCapacity = int.Parse(Console.ReadLine());
            int numberRack = 0;
            int currentSum = 0;

            while (stack.Count > 0)
            {
                currentSum += stack.Peek();
                if (currentSum > rackCapacity)
                {
                    numberRack++;
                    currentSum = 0;
                }
                else
                {
                    stack.Pop();
                }                
            }
            if (currentSum != 0)
            {
                numberRack++;
            }
            Console.WriteLine(numberRack);
        }
    }
}
