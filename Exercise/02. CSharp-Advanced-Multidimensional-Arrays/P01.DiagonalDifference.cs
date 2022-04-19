using System;
using System.Linq;

namespace P01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                              // input Data

            int[,] matrix = new int[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    int num = currentArr[columns];
                    matrix[rows, columns] = num;
                }

            }

            int firstDiagonal = 0;                                      // Work operation :)
            int secondDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < i + 1; j++)
                {
                    firstDiagonal += matrix[i, j];
                }
            }

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matrix.GetLength(0) - 1 - i; j < matrix.GetLength(0) - i; j++)
                {
                    secondDiagonal += matrix[i, j];
                }
            }

            int result = Math.Abs(firstDiagonal - secondDiagonal);              // Print output
            Console.WriteLine(result);

            //for (int i = 0; i < matrix.GetLength(0); i++)                   
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
