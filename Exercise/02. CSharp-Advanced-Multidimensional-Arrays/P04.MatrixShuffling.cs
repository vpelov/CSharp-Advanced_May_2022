using System;
using System.Linq;

namespace P04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputParam = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowMatrix = inputParam[0];
            int colMatrix = inputParam[1];
            string[,] matrix = new string[rowMatrix, colMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numberArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = numberArr[column];
                }
            }

            string cmd = Console.ReadLine();

            while (cmd != "END")
            {
                string[] command = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "swap")
                {
                    if (CheckInput(matrix, command))
                    {
                        int row = int.Parse(command[1]);
                        int col = int.Parse(command[2]);
                        int row2 = int.Parse(command[3]);
                        int col2 = int.Parse(command[4]);

                        string numberOne = matrix[row, col];
                        string numberTwo = matrix[row2, col2];

                        matrix[row, col] = numberTwo;
                        matrix[row2, col2] = numberOne;

                        GoPrint(matrix);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                cmd = Console.ReadLine();
            }

        }


        static bool CheckInput(string[,] matrix, string[] command)
        {
            bool isOK = false;
            if (command.Length == 5)
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1) && row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
                {
                    isOK = true;
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
            return isOK;
        }



        static void GoPrint(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string element = matrix[i, j];
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }


        }


    }
}
