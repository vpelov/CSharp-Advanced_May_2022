using System;

namespace P04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string currentRow = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }

            int[] position = new int[2];
            string str = Console.ReadLine();
            char searchChar = str[0];
            bool isFind = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (searchChar == matrix[i, j])
                    {
                        position[0] = i;
                        position[1] = j;
                        isFind = true;
                        break;
                    }
                }
                if (isFind)
                {
                    break;
                }
            }

            if (isFind == false)
            {
                Console.WriteLine($"{searchChar} does not occur in the matrix");
            }
            else
            {

                Console.WriteLine("(" + String.Join(", ", position) + ")");
            }
        }
    }
}