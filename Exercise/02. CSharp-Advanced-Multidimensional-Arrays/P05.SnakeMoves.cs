using System;
using System.Linq;

namespace P05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixParam = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = matrixParam[0];
            int columns = matrixParam[1];

            char[,] matrix = new char[rows, columns];
            string snake = Console.ReadLine();
            char[] charSnake = snake.ToCharArray();

            int count = 0;
            int snakeLength = charSnake.Length;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        if (count == charSnake.Length)
                        {
                            count = 0;
                        }
                        matrix[row, column] = charSnake[count];
                        count++;

                    }
                }
                else if (row % 2 != 0)
                {
                    for (int column = matrix.GetLength(1) - 1; column >= 0; column--)
                    {
                        if (count == charSnake.Length)
                        {
                            count = 0;
                        }
                        matrix[row, column] = charSnake[count];
                        count++;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
