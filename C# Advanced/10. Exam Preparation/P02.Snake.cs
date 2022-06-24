using System;

namespace P02.SnakeNew
{
    class Program
    {
        public static char[,] matrix;
        public static int food;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new char[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] charArr = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = charArr[j];
                }
            }

            (int row, int col) = GetSnakePosition();
            bool isOut = false;

            while (food < 10)
            {
                string command = Console.ReadLine();

                if (CheckMove(row, col, command))
                {
                    if (command == "up")
                    {
                        matrix[row, col] = '.';
                        row -= 1;
                        if (matrix[row, col] == '*')
                        {
                            food++;
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '.';
                            (row, col) = GetOtherBurrows(row, col);
                            matrix[row, col] = 'S';
                        }
                    }
                    else if (command == "down")
                    {
                        matrix[row, col] = '.';
                        row += 1;
                        if (matrix[row, col] == '*')
                        {
                            food++;
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '.';
                            (row, col) = GetOtherBurrows(row, col);
                            matrix[row, col] = 'S';
                        }
                    }
                    else if (command == "left")
                    {
                        matrix[row, col] = '.';
                        col -= 1;
                        if (matrix[row, col] == '*')
                        {
                            food++;
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '.';
                            (row, col) = GetOtherBurrows(row, col);
                            matrix[row, col] = 'S';
                        }
                    }
                    else if (command == "right")
                    {
                        matrix[row, col] = '.';
                        col += 1;
                        if (matrix[row, col] == '*')
                        {
                            food++;
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == '-')
                        {
                            matrix[row, col] = 'S';
                        }
                        else if (matrix[row, col] == 'B')
                        {
                            matrix[row, col] = '.';
                            (row, col) = GetOtherBurrows(row, col);
                            matrix[row, col] = 'S';
                        }
                    }
                }
                else
                {
                    matrix[row, col] = '.';
                    isOut = true;
                    break;
                }
            }

            Console.WriteLine(isOut ? "Game over!" : "You won! You fed the snake." );
            Console.WriteLine($"Food eaten: {food}");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }


        public static (int r, int c) GetOtherBurrows(int row, int col)
        {
            int newR = 0;
            int newC = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 'B' && i != row && j != col)
                    {
                        newR = i;
                        newC = j;
                    }
                }
            }
            return (newR, newC);
        }


        public static (int row, int col) GetSnakePosition()
        {
            int newR = 0;
            int newC = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'S')
                    {
                        newR = i;
                        newC = j;
                    }
                }
            }
            return (newR, newC);
        }


        public static bool IsCorectCoordinates(int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }


        public static (int newRow, int newCol) GoMoveSnake(int row, int col, string command)
        {
            int newRow = row;
            int newCol = col;
            if (command == "up")
            {
                newRow -= 1;
            }
            else if (command == "down")
            {
                newRow += 1;
            }
            else if (command == "left")
            {
                newCol -= 1;
            }
            else if (command == "right")
            {
                newCol += 1;
            }
            return (newRow, newCol);
        }


        public static bool CheckMove(int row, int col, string command)
        {
            bool isReturn = false;
            if (command == "up")
            {
                row -= 1;
                if (IsCorectCoordinates(row,col))
                {
                    isReturn = true;
                }
            }
            else if (command == "down")
            {
                row += 1;
                if (IsCorectCoordinates(row, col))
                {
                    isReturn = true;
                }
            }
            else if (command == "left")
            {
                col -= 1;
                if (IsCorectCoordinates(row, col))
                {
                    isReturn = true;
                }
            }
            else if (command == "right")
            {
                col += 1;
                if (IsCorectCoordinates(row, col))
                {
                    isReturn = true;
                }
            }
            return isReturn;
        }

    }
}
