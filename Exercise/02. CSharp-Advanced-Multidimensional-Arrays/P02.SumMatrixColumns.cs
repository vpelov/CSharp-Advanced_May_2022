using System;
using System.Linq;

namespace P02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string param = Console.ReadLine();
            int[] command = param
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = command[0];
            int columns = command[1];

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int num = currentArr[j];
                    matrix[i, j] = num;
                }
            }


            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int currentSum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int num = matrix[row, column];
                    currentSum += num;
                }
                Console.WriteLine(currentSum);
            }


        }
    }
}
