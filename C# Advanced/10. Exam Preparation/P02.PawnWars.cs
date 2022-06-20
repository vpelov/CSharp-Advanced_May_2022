using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] currentArr = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentArr[j];
                }
            }
            
            (int rowWhite, int colWhite) = GetPosition('w', matrix);
            (int rowBlack, int colBlack) = GetPosition('b', matrix);

            Dictionary<int, char> infoDictRow = new Dictionary<int, char>()
            {
                { 0, '8' },
                { 1, '7' },
                { 2, '6' },
                { 3, '5' },
                { 4, '4' },
                { 5, '3' },
                { 6, '2' },
                { 7, '1' }                
            };
            Dictionary<int, char> infoDictCol = new Dictionary<int, char>()
            {
                { 0, 'a' },
                { 1, 'b' },
                { 2, 'c' },
                { 3, 'd' },
                { 4, 'e' },
                { 5, 'f' },
                { 6, 'g' },
                { 7, 'h' }
            };


            while (true)
            {
                if (colWhite == 0)
                {
                    if (matrix[rowWhite - 1, colWhite + 1] == '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite--;
                        matrix[rowWhite, colWhite] = 'w';
                        if (rowWhite == 0)
                        {
                            char posCol = infoDictCol[colWhite];
                            char posRow = infoDictRow[rowWhite];
                            Console.WriteLine($"Game over! White pawn is promoted to a queen at {posCol}{posRow}.");
                            break;
                        }
                    }
                    else if (matrix[rowWhite - 1, colWhite + 1] != '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite -= 1;
                        colWhite += 1;
                        matrix[rowWhite, colWhite] = 'w';
                        char posCol = infoDictCol[colWhite];
                        char posRow = infoDictRow[rowWhite];
                        Console.WriteLine($"Game over! White capture on {posCol}{posRow}.");
                        break;
                    }
                    
                }
                else if (colWhite == 7)
                {
                    if (matrix[rowWhite - 1, colWhite - 1] == '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite--;
                        matrix[rowWhite, colWhite] = 'w';
                        if (rowWhite == 0)
                        {
                            char posCol = infoDictCol[colWhite];
                            char posRow = infoDictRow[rowWhite];
                            Console.WriteLine($"Game over! White pawn is promoted to a queen at {posCol}{posRow}.");
                            break;
                        }
                    }
                    else if (matrix[rowWhite - 1, colWhite - 1] != '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite -= 1;
                        colWhite -= 1;
                        matrix[rowWhite, colWhite] = 'w';
                        char posCol = infoDictCol[colWhite];
                        char posRow = infoDictRow[rowWhite];
                        Console.WriteLine($"Game over! White capture on {posCol}{posRow}.");
                        break;
                    }
                   
                }
                else
                {
                    if (matrix[rowWhite - 1, colWhite - 1] == '-' && matrix[rowWhite - 1, colWhite + 1] == '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite--;
                        matrix[rowWhite, colWhite] = 'w';
                        if (rowWhite == 0)
                        {
                            char posCol = infoDictCol[colWhite];
                            char posRow = infoDictRow[rowWhite];
                            Console.WriteLine($"Game over! White pawn is promoted to a queen at {posCol}{posRow}.");
                            break;
                        }
                    }
                    else if (matrix[rowWhite - 1, colWhite - 1] != '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite -= 1;
                        colWhite -= 1;
                        matrix[rowWhite, colWhite] = 'w';
                        char posCol = infoDictCol[colWhite];
                        char posRow = infoDictRow[rowWhite];
                        Console.WriteLine($"Game over! White capture on {posCol}{posRow}.");
                        break;
                    }
                    else if (matrix[rowWhite - 1, colWhite + 1] != '-')
                    {
                        matrix[rowWhite, colWhite] = '-';
                        rowWhite -= 1;
                        colWhite += 1;
                        matrix[rowWhite, colWhite] = 'w';
                        char posCol = infoDictCol[colWhite];
                        char posRow = infoDictRow[rowWhite];
                        Console.WriteLine($"Game over! White capture on {posCol}{posRow}.");
                        break;
                    }

                }


                if (colBlack == 0)
                {
                    if (matrix[rowBlack + 1, colBlack + 1] == '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        matrix[rowBlack, colBlack] = 'b';
                        if (rowBlack == 7)
                        {
                            char posCol = infoDictCol[colBlack];
                            char posRow = infoDictRow[rowBlack];
                            Console.WriteLine($"Game over! Black pawn is promoted to a queen at {posCol}{posRow}.");
                            break;
                        }
                    }
                    else if (matrix[rowBlack + 1, colBlack + 1] != '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        colBlack++;
                        matrix[rowBlack, colBlack] = 'b';
                        char posCol = infoDictCol[colBlack];
                        char posRow = infoDictRow[rowBlack];
                        Console.WriteLine($"Game over! Black capture on {posCol}{posRow}.");
                        break;
                    }
                }
                else if (colBlack == 7)
                {
                    if (matrix[rowBlack + 1, colBlack - 1] == '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        matrix[rowBlack, colBlack] = 'b';
                        if (rowBlack == 7)
                        {
                            char posCol = infoDictCol[colBlack];
                            char posRow = infoDictRow[rowBlack];
                            Console.WriteLine($"Game over! Black pawn is promoted to a queen at {posCol}{posRow}.");
                            break;
                        }
                    }
                    else if (matrix[rowBlack + 1, colBlack - 1] != '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        colBlack--;
                        matrix[rowBlack, colBlack] = 'b';
                        char posCol = infoDictCol[colBlack];
                        char posRow = infoDictRow[rowBlack];
                        Console.WriteLine($"Game over! Black capture on {posCol}{posRow}.");
                        break;
                    }
                }
                else
                {
                    if (matrix[rowBlack + 1, colBlack + 1] == '-' && matrix[rowBlack + 1, colBlack - 1] == '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        matrix[rowBlack, colBlack] = 'b';
                        if (rowBlack == 7)
                        {
                            char posCol = infoDictCol[colBlack];
                            char posRow = infoDictRow[rowBlack];
                            Console.WriteLine($"Game over! Black pawn is promoted to a queen at {posCol}{posRow}.");
                            break;
                        }
                    }
                    else if (matrix[rowBlack + 1, colBlack + 1] != '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        colBlack++;
                        matrix[rowBlack, colBlack] = 'b';
                        char posCol = infoDictCol[colBlack];
                        char posRow = infoDictRow[rowBlack];
                        Console.WriteLine($"Game over! Black capture on {posCol}{posRow}.");
                        break;
                    }
                    else if (matrix[rowBlack + 1, colBlack - 1] != '-')
                    {
                        matrix[rowBlack, colBlack] = '-';
                        rowBlack++;
                        colBlack--;
                        matrix[rowBlack, colBlack] = 'b';
                        char posCol = infoDictCol[colBlack];
                        char posRow = infoDictRow[rowBlack];
                        Console.WriteLine($"Game over! Black capture on {posCol}{posRow}.");
                        break;
                    }
                }

            }

            //Console.WriteLine();
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
        }

        public static (int, int) GetPosition(char pawn, char[,] matrix)
        {
            int row = 0;
            int col = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == pawn)
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            return (row, col);
        }
    }
 }



