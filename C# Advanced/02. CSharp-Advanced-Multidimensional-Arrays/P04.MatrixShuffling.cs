using System;
using System.Linq;

namespace P04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[dimensions[0], dimensions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] stringArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = stringArray[j];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmd[0] == "swap" && cmd.Length == 5)
                {
                    int row1 = int.Parse(cmd[1]);
                    int col1 = int.Parse(cmd[2]);
                    int row2 = int.Parse(cmd[3]);
                    int col2 = int.Parse(cmd[4]);
                    if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) && row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
                    {
                        string magicString = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = magicString;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
