using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowPosOfficer = 0;
            int colPosOfficer = 0;
            Dictionary<int, int> mirrors = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] charArr = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = charArr[j];
                    if (matrix[i,j] == 'A')
                    {
                        rowPosOfficer = i;
                        colPosOfficer = j;
                    }

                    if (matrix[i, j] == 'M')
                    {
                        mirrors.Add(i, j);
                    }
                }
            }

            int boughtSwords = 0;
            bool isOutArmory = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (boughtSwords > 65)
                {
                    break;
                }

                if (IsOutOfArmory(command, matrix, rowPosOfficer, colPosOfficer))
                {
                    matrix[rowPosOfficer, colPosOfficer] = '-';
                    isOutArmory = true;
                    break;
                }

                if (command == "up")
                {
                    matrix[rowPosOfficer, colPosOfficer] = '-';
                    rowPosOfficer--;
                    if (matrix[rowPosOfficer, colPosOfficer] == 'M')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = '-';
                        (rowPosOfficer, colPosOfficer) = ChangePosition(rowPosOfficer, colPosOfficer, mirrors);
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (matrix[rowPosOfficer, colPosOfficer] == '-')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (char.IsDigit(matrix[rowPosOfficer, colPosOfficer]))
                    {
                        boughtSwords += int.Parse(matrix[rowPosOfficer, colPosOfficer].ToString());
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                }
                else if (command == "down")
                {
                    matrix[rowPosOfficer, colPosOfficer] = '-';
                    rowPosOfficer++;
                    if (matrix[rowPosOfficer, colPosOfficer] == 'M')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = '-';
                        (rowPosOfficer, colPosOfficer) = ChangePosition(rowPosOfficer, colPosOfficer, mirrors);
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (matrix[rowPosOfficer, colPosOfficer] == '-')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (char.IsDigit(matrix[rowPosOfficer, colPosOfficer]))
                    {
                        boughtSwords += int.Parse(matrix[rowPosOfficer, colPosOfficer].ToString());
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                }
                else if (command == "left")
                {
                    matrix[rowPosOfficer, colPosOfficer] = '-';
                    colPosOfficer--;
                    if (matrix[rowPosOfficer, colPosOfficer] == 'M')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = '-';
                        (rowPosOfficer, colPosOfficer) = ChangePosition(rowPosOfficer, colPosOfficer, mirrors);
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (matrix[rowPosOfficer, colPosOfficer] == '-')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (char.IsDigit(matrix[rowPosOfficer, colPosOfficer]))
                    {
                        boughtSwords += int.Parse(matrix[rowPosOfficer, colPosOfficer].ToString());
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                }
                else if (command == "right")
                {
                    matrix[rowPosOfficer, colPosOfficer] = '-';
                    colPosOfficer++;
                    if (matrix[rowPosOfficer, colPosOfficer] == 'M')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = '-';
                        (rowPosOfficer, colPosOfficer) = ChangePosition(rowPosOfficer, colPosOfficer, mirrors);
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (matrix[rowPosOfficer, colPosOfficer] == '-')
                    {
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                    else if (char.IsDigit(matrix[rowPosOfficer, colPosOfficer]))
                    {
                        boughtSwords += int.Parse(matrix[rowPosOfficer, colPosOfficer].ToString());
                        matrix[rowPosOfficer, colPosOfficer] = 'A';
                    }
                }

            }

            if (isOutArmory)
            {
                Console.WriteLine("I do not need more swords!");
            }
            else
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }

            Console.WriteLine($"The king paid {boughtSwords} gold coins.");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }


        }

        public static bool IsOutOfArmory(string command, char[,] matrix, int row, int col)
        {
            if (command == "up" && row == 0)
            {
                return true;
            }
            else if (command == "down" && row == matrix.GetLength(0) - 1)
            {
                return true;
            }
            else if (command == "left" && col == 0)
            {
                return true;
            }
            else if (command == "right" && col == matrix.GetLength(1) - 1)
            {
                return true;
            }
            return false;
        }


        public static (int rows, int cols) ChangePosition(int row, int col, Dictionary<int, int> mirrors)
        {
            foreach (var item in mirrors)
            {
                if (row != item.Key && col != item.Value)
                {
                    row = item.Key;
                    col = item.Value;
                    break;
                }
            }

            return (row, col);

        }
    }
}
