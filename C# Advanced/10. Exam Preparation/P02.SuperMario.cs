using System;
using System.Linq;

namespace P02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int livesMario = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] charLine = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = charLine[j];
                }
            }


            (int rowPrincess, int colPrincess) = GetPosition('P', matrix);
            (int rowMario, int colMario) = GetPosition('M', matrix);

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                char[] m = command[0].ToCharArray();
                char move = m[0];
                int rowEnemy = int.Parse(command[1]);
                int colEnemy = int.Parse(command[2]);

                if (CheskOutStep(move, matrix, rowMario, colMario))
                {
                    matrix[rowMario, colMario] = '-';
                    if (move == 'W')
                    {
                        rowMario -= 1;
                    }
                    else if (move == 'S')
                    {
                        rowMario += 1;
                    }
                    else if (move == 'A')
                    {
                        colMario -= 1;
                    }
                    else if (move == 'D')
                    {
                        colMario += 1;
                    }
                    livesMario -= 1;
                }
                else
                {
                    livesMario -= 1;
                }                

                if (rowMario == rowEnemy && colMario == colEnemy)
                {
                    livesMario -= 2;
                    if (livesMario <= 0)
                    {
                        matrix[rowMario, colMario] = 'X';
                        Console.WriteLine($"Mario died at {rowMario};{colMario}.");
                        break;
                    }

                    matrix[rowEnemy, colEnemy] = 'B';
                }
                else
                {
                    matrix[rowEnemy, colEnemy] = 'B';
                }

                if (rowMario == rowPrincess && colMario == colPrincess)
                {
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {livesMario}");
                    matrix[rowMario, colMario] = '-';
                    break;
                }


                if (livesMario <= 0)
                {
                    matrix[rowMario, colMario] = 'X';
                    Console.WriteLine($"Mario died at {rowMario};{colMario}.");
                    break;
                }

                
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }


        }

        
        public static (int row, int col) GetPosition(char ch, char[,] matrix)
        {
            int row = 0;
            int col = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (ch == matrix[i,j])
                    {
                        row = i;
                        col = j;                       
                    }
                }
            }
            return (row, col);
        }


        public static bool CheskOutStep(char move, char[,] matrix, int row, int col)
        {
            bool isMove = true;
            if (move == 'W')
            {
                if (row - 1 < 0)
                {
                    isMove = false;
                }
            }
            else if (move == 'S')
            {
                if (row + 1 > matrix.GetLength(0) -1)
                {
                    isMove = false;
                }
            }
            else if (move == 'A')
            {
                if (col - 1 < 0)
                {
                    isMove = false;
                }
            }
            else if (move == 'D')
            {
                if (col + 1 > matrix.GetLength(1) - 1)
                {
                    isMove = false;
                }
            }
            return isMove;
        }


    }
}
