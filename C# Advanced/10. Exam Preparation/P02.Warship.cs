using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Warships
{
    internal class Program
    {
        private static int size;
        private static char[,] matrix;

        private static int firstPlayerShipCount = 0;
        private static int secondPlayerShipCount = 0;
        private static int totalShipSunk = 0;

        private static char regularPosition = '*';
        private static char firstBattleShip = '<';
        private static char secondBattleShip = '>';
        private static char mine = '#';

        static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());
            string[] coordinates = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

            GetMatrix();

            bool winner = false;
            string winPlayer = string.Empty;

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] coordinate = coordinates[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); ;
                int row = coordinate[0];
                int col = coordinate[1];

                if (CheckIsValidCode(row, col))
                {
                    Attack(row, col);
                }

                if (firstPlayerShipCount == 0)
                {
                    winner = true;
                    winPlayer = "Two";
                    break;
                }
                else if (secondPlayerShipCount == 0)
                {
                    winner = true;
                    winPlayer = "One";
                    break;
                }
            }

            Console.WriteLine(winner ? $"Player {winPlayer} has won the game! {totalShipSunk} ships have been sunk in the battle." : $"It's a draw! Player One has {firstPlayerShipCount} left. Player Two has {secondPlayerShipCount} left.");

        }

        private static void Attack(int row, int col)
        {
            if (matrix[row, col] == firstBattleShip)
            {
                firstPlayerShipCount--;
                matrix[row, col] = 'X';
                totalShipSunk++;
            }
            else if (matrix[row, col] == secondBattleShip)
            {
                secondPlayerShipCount--;
                matrix[row, col] = 'X';
                totalShipSunk++;
            }
            else if (matrix[row, col] == mine)
            {
                MineAttack(row, col);
            }
        }

        private static void MineAttack(int row, int col)
        {
            int[] firstRow = new int[] { -1, -1, -1, 1, 1, 1, 0, 0 };
            int[] secondRow = new int[] { -1, 0, 1, -1, 0, 1, -1, 1 };

            for (int i = 0; i < firstRow.Length; i++)
            {
                int newRow = row + firstRow[i];
                int newCol = col + secondRow[i];

                if (CheckIsValidCode(newRow, newCol))
                {
                    if (matrix[newRow, newCol] == firstBattleShip)
                    {
                        firstPlayerShipCount--;
                        matrix[newRow, newCol] = 'X';
                        totalShipSunk++;
                    }
                    if (matrix[newRow, newCol] == secondBattleShip)
                    {
                        secondPlayerShipCount--;
                        matrix[newRow, newCol] = 'X';
                        totalShipSunk++;
                    }
                    else if (matrix[newRow, newCol] == regularPosition)
                        continue;
                }

                if (firstPlayerShipCount == 0 || secondPlayerShipCount == 0)
                {
                    break;
                }
            }
        }

        private static void GetMatrix()
        {
            matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] fields = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = fields[j];

                    if (matrix[i, j] == firstBattleShip)
                    {
                        firstPlayerShipCount++;
                    }
                    else if (matrix[i, j] == secondBattleShip)
                    {
                        secondPlayerShipCount++;
                    }
                }
            }
        }

        private static bool CheckIsValidCode(int row, int col)
        {
            if (row < 0 || row > matrix.GetLength(0) - 1 || col < 0 || col > matrix.GetLength(1) - 1)
            {
                return false;
            }
            return true;
        }
    }
}