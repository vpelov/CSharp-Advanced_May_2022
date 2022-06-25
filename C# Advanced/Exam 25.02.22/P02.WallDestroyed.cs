using System;

namespace P02.WallDestroyed
{
    class Program
    {
        public static char[,] matrix;
        public static int countHole = 1;
        public static int hitRod = 0;


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new char[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] currArr = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currArr[j];
                }
            }

            bool isEhit = false;
            string command = Console.ReadLine();

            (int row, int col) = GetVankoPosition();

            while (command != "End")
            {


                if (!IsMove(command, row, col))
                {
                    if (command == "up")
                    {
                        matrix[row, col] = '*';
                        row -= 1; //

                        if (matrix[row, col] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRod++;
                            row += 1;  //
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == 'C')
                        {
                            isEhit = true;
                            countHole++;
                            matrix[row, col] = 'E';
                            break;
                        }
                        else if (matrix[row, col] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{row}, {col}]!");
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            countHole++;
                            matrix[row, col] = 'V';
                        }

                    }
                    else if (command == "down")
                    {
                        matrix[row, col] = '*';
                        row += 1; //

                        if (matrix[row, col] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRod++;
                            row -= 1;  //
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == 'C')
                        {
                            isEhit = true;
                            countHole++;
                            matrix[row, col] = 'E';
                            break;
                        }
                        else if (matrix[row, col] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{row}, {col}]!");
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            countHole++;
                            matrix[row, col] = 'V';
                        }

                    }
                    else if (command == "left")
                    {
                        matrix[row, col] = '*';
                        col -= 1; //

                        if (matrix[row, col] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRod++;
                            col += 1;  //
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == 'C')
                        {
                            isEhit = true;
                            countHole++;
                            matrix[row, col] = 'E';
                            break;
                        }
                        else if (matrix[row, col] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{row}, {col}]!");
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            countHole++;
                            matrix[row, col] = 'V';
                        }

                    }
                    else if (command == "right")
                    {
                        matrix[row, col] = '*';
                        col += 1; //

                        if (matrix[row, col] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            hitRod++;
                            col -= 1;  //
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == 'C')
                        {
                            isEhit = true;
                            countHole++;
                            matrix[row, col] = 'E';
                            break;
                        }
                        else if (matrix[row, col] == '*')
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{row}, {col}]!");
                            matrix[row, col] = 'V';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            countHole++;
                            matrix[row, col] = 'V';
                        }

                    }
                }
                else
                {
                    command = Console.ReadLine();
                    continue;
                }


                command = Console.ReadLine();

            }

            if (isEhit)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {countHole} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {countHole} hole(s) and he hit only {hitRod} rod(s).");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }

        }



        public static (int row, int col) GetVankoPosition()
        {
            int r = 0;
            int c = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'V')
                    {
                        r = i;
                        c = j;
                    }
                }
            }
            return (r, c);
        }


        public static bool GoOutMatrix(int row, int col)
        {
            if (row < 0 && row > matrix.GetLength(0) - 1 && col < 0 && col > matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        public static bool IsMove(string command, int row, int col)
        {
            bool isMove = false;

            if (command == "up")
            {
                if (row - 1 < 0)
                {
                    isMove = true;
                }
                else
                {

                    isMove = false;
                }

            }
            else if (command == "down")
            {
                if (row + 1 > matrix.GetLength(0) - 1)
                {
                    isMove = true;
                }
                else
                {

                    isMove = false;
                }
            }
            else if (command == "left")
            {
                if (col - 1 < 0)
                {
                    isMove = true;
                }
                else
                {

                    isMove = false;
                }
            }
            else if (command == "right")
            {
                if (col + 1 > matrix.GetLength(1) - 1)
                {
                    isMove = true;
                }
                else
                {

                    isMove = false;
                }
            }
            return isMove;
        }




    }
}
