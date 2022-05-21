using System;

namespace P07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chArr = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chArr[col];
                }
            }



            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    char currChar = matrix[rows, cols];
                    if (currChar == 'K')
                    {
                        // TODO...............
                    }
                }
            }


            
            
            


            //for (int i = 0; i < matrix.GetLength(0); i++)           // For my check !!!
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}
        }

        static bool CheckUpTwoRow(char[,] matrix, int row, int col)
        {
            bool isOk = false;

            
            // TODO........

            return isOk;
        }


    }
}
