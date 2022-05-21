using System;
using System.Linq;

namespace P03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[dimension[0], dimension[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] numbersArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbersArray[j];
                }
            }

            string matrixResult = string.Empty;
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        matrixResult = $"{matrix[i, j] + " " + matrix[i, j + 1] + " " + matrix[i, j + 2] + "\n" + matrix[i+1, j] + " " + matrix[i+1, j + 1] + " " + matrix[i+1, j + 2] + "\n" + matrix[i + 2, j] + " " + matrix[i + 2, j + 1] + " " + matrix[i + 2, j + 2] }";
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(matrixResult);
        }
    }
}
