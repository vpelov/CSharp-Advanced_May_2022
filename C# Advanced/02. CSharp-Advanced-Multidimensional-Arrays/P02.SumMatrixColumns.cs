using System;
using System.Linq;

namespace P02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(',')
                .Select(int.Parse)
                .ToArray();
            int row = dimension[0];
            int col = dimension[1];
            int[,] matrix = new int[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentArray[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int currentSum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    currentSum += matrix[j, i];
                }
                Console.WriteLine(currentSum);
            }
        }
    }
}
