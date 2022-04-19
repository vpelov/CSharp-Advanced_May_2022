using System;
using System.Linq;

namespace P02._2x2SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensionsMarix = Console.ReadLine()                      // Read input data
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensionsMarix[0];
            int columns = dimensionsMarix[1];
            char[,] matrix = new char[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] str = Console.ReadLine().Split(' ').ToArray();
                char[] chArr = str.SelectMany(x => x).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentChar = chArr[col];
                    matrix[row, col] = currentChar;
                }
            }

            int count = 0;                                              // working operation
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)                 
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char ch = matrix[row, col];
                    if (ch == matrix[row, col + 1] && ch == matrix[row + 1, col] && ch == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
