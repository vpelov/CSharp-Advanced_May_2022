using System;
using System.Linq;

namespace P01.SumMatrixElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int row = dimension[0];
            int col = dimension[1];
            int[,] matrix = new int[row, col];          

            for (int i = 0; i < row; i++)
            {
                int[] currentArray = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = currentArray[j];
                }
            }

            int totalSum = 0;
            foreach (int elements in matrix)
            {
                totalSum += elements;
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(totalSum);

        }
    }
}
