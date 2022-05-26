using System;
using System.Linq;

namespace P03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] printArray = numbersArray.OrderByDescending(x => x).Take(3).ToArray();

            for (int i = 0; i < printArray.Length; i++)
            {
                Console.Write($"{printArray[i]} ");
            }
        }
    }
}
