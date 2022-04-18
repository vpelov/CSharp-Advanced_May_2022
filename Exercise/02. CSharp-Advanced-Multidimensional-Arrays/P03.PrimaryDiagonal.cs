using System;
using System.Linq;

namespace P03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];                  // Read input Matrix 
           
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] currantArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    int num = currantArr[columns];
                    matrix[rows, columns] = num;
                }

            }

            int sum = 0;                            // Operation
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = rows; columns < rows + 1; columns++)
                {
                    int number = matrix[rows, columns];
                    sum += number;
                }
            }


            Console.WriteLine(sum);

        }
    }
}
