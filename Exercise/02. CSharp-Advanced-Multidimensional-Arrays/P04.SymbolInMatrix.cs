using System;
using System.Linq;

namespace P04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] currentChar = Console.ReadLine().ToCharArray();

                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    char ch = currentChar[columns];
                    matrix[rows, columns] = ch;
                }
            }


            int row;
            int column;
            bool isFind = true;
            char[] symbol = Console.ReadLine().ToCharArray();
            char searchCh = symbol[0];
           
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    char currentChar = matrix[rows, columns];
                    if (currentChar == searchCh)
                    {
                        row = rows;
                        column = columns;
                        Console.WriteLine($"({row}, {column})");
                        isFind =false;
                        break;
                    }
                                        
                }
                if (isFind == false)
                {
                    break;
                }
            }


            if (isFind)
            {
                Console.WriteLine($"{searchCh} does not occur in the matrix ");
            }

        }
    }
}
