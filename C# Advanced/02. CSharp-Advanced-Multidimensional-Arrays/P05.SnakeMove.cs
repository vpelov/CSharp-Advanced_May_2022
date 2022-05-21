using System;
using System.Linq;

namespace P05.SnakeMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];
            string inputData = Console.ReadLine();
            char[] snake = inputData.ToCharArray();
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[count];
                        count++;
                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                    }
                }
                else
                {
                    for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                    {
                        matrix[row, i] = snake[count];
                        count++;
                        if (count == snake.Length)
                        {
                            count = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}
