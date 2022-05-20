using System;
using System.Linq;

namespace P05.SquareWithMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = dimension[0];
            int col = dimension[1];

            int[,] matrix = new int[row, col];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] numberArray = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numberArray[cols];
                }
            }

            int maxSum = int.MinValue;
            int[,] printMatrix = new int[2, 2];

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        printMatrix[0, 0] = matrix[i, j];
                        printMatrix[0, 1] = matrix[i, j + 1];
                        printMatrix[1, 0] = matrix[i + 1, j];
                        printMatrix[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }


            for (int i = 0; i < printMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < printMatrix.GetLength(1); j++)
                {
                    Console.Write($"{printMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
