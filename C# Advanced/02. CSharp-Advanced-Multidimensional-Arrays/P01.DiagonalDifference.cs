using System;
using System.Linq;

namespace P01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)                 //Read input
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }

            int sumFirstDiagonal = 0;                           // Operation
            int sumSecondDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < i + 1; j++)
                {
                    sumFirstDiagonal += matrix[i, j];
                }
            }

            for (int i = matrix.GetLength(0) - 1; i >= 0 ; i--)
            {
                for (int j = matrix.GetLength(1) - i - 1; j < matrix.GetLength(1) - i; j++)
                {
                    sumSecondDiagonal += matrix[i, j];
                }
            }

            Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
        }
    }
}
