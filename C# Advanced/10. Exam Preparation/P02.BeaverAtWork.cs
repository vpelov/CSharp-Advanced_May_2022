using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BeaverAtWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read MATRIX !!!
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentCharArray = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = currentCharArray[col];
                }
            }

            int allWoodBranches = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != '-' && matrix[i,j] != 'F')
                    {
                        allWoodBranches++;
                    }
                }
            }

            // Get Beaver
            (int r, int c) = GetBeaver(matrix);

            List<char> woodBranchCount = new List<char>();


            // COMMAND
            string command = Console.ReadLine();            
            while (command != "end")
            {

                if (command == "up")
                {
                    if (CheckCoordinates(r, c-1, matrix))
                    {
                        matrix[r, c] = '-';
                        c = c - 1;  
                        
                        if (matrix[r,c] == '-')
                        {
                            matrix[r, c] = 'B';           //
                            continue; 
                        }                        
                        else if (matrix[r,c] == 'F')
                        {
                            matrix[r,c] = '-';
                            (r, c) = NewCoordinates(r, c, matrix, command); //---------------------
                            if (matrix[r,c] == '-')
                            {
                                matrix[r, c] = 'B';     //
                                continue;
                            }
                            else if (matrix[r, c] == 'F')
                            {
                                matrix[r, c] = '-';
                                (r, c) = NewCoordinates(r, c, matrix, command);
                                matrix[r, c] = 'B';        //
                            }
                            else
                            {
                                woodBranchCount.Add(matrix[r, c]);
                                matrix[r, c] = 'B';      //
                            }
                        }
                        else
                        {
                            woodBranchCount.Add(matrix[r, c]);
                            matrix[r, c] = 'B';      //
                        }
                    }
                    else
                    {
                        if (woodBranchCount.Count > 0)
                        {
                            woodBranchCount.RemoveAt(woodBranchCount.Count - 1);
                        }
                    }
                }
                else if (command == "down")
                {
                    if (CheckCoordinates(r, c + 1, matrix))
                    {
                        matrix[r, c] = '-';
                        c = c + 1;

                        if (matrix[r, c] == '-')
                        {
                            matrix[r, c] = 'B';
                            continue; ;
                        }
                        else if (matrix[r, c] == 'F')
                        {
                            matrix[r, c] = '-';
                            (r, c) = NewCoordinates(r, c, matrix, command); //---------------------
                            if (matrix[r, c] == '-')
                            {
                                matrix[r, c] = 'B';
                                continue;
                            }
                            else if (matrix[r, c] == 'F')
                            {
                                matrix[r, c] = '-';
                                (r, c) = NewCoordinates(r, c, matrix, command);
                                matrix[r, c] = 'B';
                            }
                            else
                            {
                                woodBranchCount.Add(matrix[r, c]);
                                matrix[r, c] = 'B';
                            }
                        }
                        else
                        {
                            woodBranchCount.Add(matrix[r, c]);
                            matrix[r, c] = 'B';
                        }
                    }
                    else
                    {
                        if (woodBranchCount.Count > 0)
                        {
                            woodBranchCount.RemoveAt(woodBranchCount.Count - 1);
                        }
                    }
                }
                else if (command == "right")
                {
                    if (CheckCoordinates(r + 1, c, matrix))
                    {
                        matrix[r, c] = '-';
                        r = r +1;

                        if (matrix[r, c] == '-')
                        {
                            matrix[r, c] = 'B';
                            continue; ;
                        }
                        else if (matrix[r, c] == 'F')
                        {
                            matrix[r, c] = '-';
                            (r, c) = NewCoordinates(r, c, matrix, command);                            
                            if (matrix[r, c] == '-')
                            {
                                matrix[r, c] = 'B';
                                continue;
                            }
                            else if (matrix[r, c] == 'F')
                            {
                                matrix[r, c] = '-';
                                (r, c) = NewCoordinates(r, c, matrix, command);
                            }
                            else
                            {
                                woodBranchCount.Add(matrix[r, c]);
                                matrix[r, c] = '-';
                            }
                        }
                        else
                        {
                            woodBranchCount.Add(matrix[r, c]);
                            matrix[r, c] = '-';
                        }
                    }
                    else
                    {
                        if (woodBranchCount.Count > 0)
                        {
                            woodBranchCount.RemoveAt(woodBranchCount.Count - 1);
                        }
                    }
                }
                else if (command == "left")
                {
                    if (CheckCoordinates(r - 1, c, matrix))
                    {
                        matrix[r, c] = '-';
                        r = r - 1;

                        if (matrix[r, c] == '-')
                        {
                            continue; ;
                        }
                        else if (matrix[r, c] == 'F')
                        {
                            matrix[r, c] = '-';
                            (r, c) = NewCoordinates(r, c, matrix, command); //---------------------
                            if (matrix[r, c] == '-')
                            {
                                continue;
                            }
                            else if (matrix[r, c] == 'F')
                            {
                                matrix[r, c] = '-';
                                (r, c) = NewCoordinates(r, c, matrix, command);
                            }
                            else
                            {
                                woodBranchCount.Add(matrix[r, c]);
                                matrix[r, c] = '-';
                            }
                        }
                        else
                        {
                            woodBranchCount.Add(matrix[r, c]);
                            matrix[r, c] = '-';
                        }
                    }
                    else
                    {
                        if (woodBranchCount.Count > 0)
                        {
                            woodBranchCount.RemoveAt(woodBranchCount.Count - 1);
                        }
                    }
                }



                command = Console.ReadLine();
            }

            List<char> woodBranchesLeft = new List<char>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != '-' && matrix[i, j] != 'F')
                    {
                        woodBranchesLeft.Add(matrix[i,j]);
                    }
                }
            }

            if (woodBranchesLeft.Count == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {woodBranchCount.Count} wood branches: {string.Join(", ", woodBranchCount)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranchesLeft.Count} branches left.");
            }
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write($"{matrix[i,y]} ");
                }
                Console.WriteLine();
            }

        }

         
        private static (int newRow, int newCol) NewCoordinates(int row, int col, char[,] matrix, string command)
        {
            matrix[row, col] = '-';
            if (IsNotLastIndex(row, col, matrix, command))
            {
                if (command == "up")
                {
                    return (row - 1, col);
                }
                else if (command == "down")
                {
                    return (row + 1, col);
                }
                else if (command == "right")
                {
                    return (row, col + 1);
                }
                else if (command == "left")
                {
                    return (row, col - 1);
                }
            }
            else
            {
                if (command == "up")
                {
                    return (matrix.GetLength(1) - 1, col);
                }
                else if (command == "down")
                {
                    return (0, col);
                }
                else if (command == "right")
                {
                    return (col, 0);
                }
                else if (command == "left")
                {
                    return (col, matrix.GetLength(0));
                }
            }
            throw new Exception();            
        }



        private static bool IsNotLastIndex(int r, int c, char[,] matrix, string command)
        {
            if (command == "up" && r > 1 || command == "down" && r < matrix.GetLength(1) - 1 || command == "Left" && c > 1 || command == "right" && c < matrix.GetLength(0) - 1)
            {
                return true;
            }
            return false;
        }

        private static bool CheckCoordinates(int r, int v, char[,] matrix)   // in, out beaver at pond
        {
            if (0 <= r && r < matrix.GetLength(0) && 0 <= v && v < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }


        private static (int row, int col) GetBeaver(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[i,y] == 'B')
                    {
                        return (i, y);
                    }
                }
            }
            throw new Exception("Invalid Beaver coocrinates!");
        }
    }
}
