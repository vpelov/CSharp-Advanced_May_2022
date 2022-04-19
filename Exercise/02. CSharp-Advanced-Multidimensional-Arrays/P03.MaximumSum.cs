using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inData = Console.ReadLine()                       //Read data
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = inData[0];
            int column = inData[1];
            int[,] matrix = new int[row, column];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currentData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    int num = currentData[columns];
                    matrix[rows, columns] = num;
                }
            }

            int[,] result = new int[3, 3];                              // Work with data
            int maxSum = 0;

            for (int rows = 0; rows <= matrix.GetLength(0) - result.GetLength(0); rows++)
            {
                for (int columns = 0; columns <= matrix.GetLength(1) - result.GetLength(1); columns++)
                {
                    int currentRow = rows;
                    int currentColumn = columns;
                    int currentSum = GetSquareSum(matrix, currentRow, currentColumn);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;

                        result = GetResultMatrix(matrix, currentRow, currentColumn);
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");                       // Print data

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int number = result[i, j];
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }

        }


        static int GetSquareSum(int[,] matrix, int row, int column)
        {
            int sum = 0;
            for (int i = row; i < row + 3; i++)
            {
                for (int j = column; j < column + 3; j++)
                {
                    int num = matrix[i, j];
                    sum += num;
                }
            }

            return sum;
        }



        static int[,] GetResultMatrix(int[,] matrix, int row, int column)
        {
            Queue<int> timeQueue = new Queue<int>();
            for (int i = row; i < row + 3; i++)
            {
                for (int j = column; j < column + 3; j++)
                {
                    int number = matrix[i, j];
                    timeQueue.Enqueue(number);
                }
            }

            int[,] result = new int[3, 3];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    int num = timeQueue.Dequeue();
                    result[i, j] = num;
                }
            }

            return result;
        }
    }
}
