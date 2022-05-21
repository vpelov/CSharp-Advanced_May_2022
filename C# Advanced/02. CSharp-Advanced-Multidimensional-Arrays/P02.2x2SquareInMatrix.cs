using System;
using System.Linq;

namespace P02._2x2SquareInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[dimension[0], dimension[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] charArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    matrix[i, j] = charArray[j];
                }
            }

            int result = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {                    
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
