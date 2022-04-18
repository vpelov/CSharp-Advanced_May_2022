using System;
using System.Linq;

namespace P01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] paramMatrix = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = paramMatrix[0];
            int columns = paramMatrix[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    
                    matrix[row, column] = currentRow[column];
                }
            }

            int outputRows = matrix.GetLength(0);
            int outputColums = matrix.GetLength(1);
            int totalSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = matrix[i, j];
                    totalSum += num;
                }
            }

            Console.WriteLine(outputRows);
            Console.WriteLine(outputColums);
            Console.WriteLine(totalSum);
        }
    }
}
