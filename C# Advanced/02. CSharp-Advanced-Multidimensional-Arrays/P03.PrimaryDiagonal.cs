using System;
using System.Linq;

namespace P03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] array = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[j];
                }
            }

            int totalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < i + 1; j++)
                {
                    totalSum += matrix[i, j];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
