using System;
using System.Linq;

namespace P05SquareWithMaximumSum
{
    internal class P05SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] param = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = param[0];
            int columns = param[1];

            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    int num = currentArr[column];
                    matrix[row, column] = num;
                }

            }

            
            int maxSum = int.MinValue;
            int rowMax = 0;
            int columnMax = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int num = matrix[i, j] + matrix[i, j + 1]
                        + matrix[i + 1,  j] + matrix[i + 1, j + 1];
                    if (num > maxSum)
                    {
                        maxSum = num;
                        rowMax = i;
                        columnMax = j;
                    }
                }
            }


            for (int i = rowMax; i < rowMax + 2; i++)
            {
                for (int j = columnMax; j < columnMax + 2; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);                        
        }
    }
}
