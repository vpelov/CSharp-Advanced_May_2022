using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Garden
{
    public class Program
    {

        private static int[,] garden;
        private static int[,] newGarden;
        private static List<(int, int)> posList = new List<(int, int)>();


        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            garden = new int[dimension[0], dimension[1]];
            newGarden = new int[dimension[0], dimension[1]];

            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    garden[i, j] = 0;
                }
            }

            string command = Console.ReadLine();
            while (command != "Bloom Bloom Plow")
            {

                int[] position = command.Split().Select(int.Parse).ToArray();
                int row = position[0];
                int col = position[1];
                if (HasIsValidPosition(row, col))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    posList.Add((row, col));
                }

                command = Console.ReadLine();
            }

            GoBloomPlow();

            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write($"{garden[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void GoBloomPlow()
        {
            foreach (var item in posList)
            {
                (int row, int col) = item;

                for (int i = 0; i < garden.GetLength(0); i++)
                {
                    for (int j = 0; j < garden.GetLength(1); j++)
                    {
                        if (i == row && j != col)
                        {
                            garden[i, j] += 1;
                        }
                        if (j == col && row != i)
                        {
                            garden[i, j] += 1;
                        }

                        if (i == row && j== col)
                        {
                            garden[i, j] += 1;
                        }
                    }
                }
            }
        }

        private static bool HasIsValidPosition(int row, int col)
        {
            if (row < 0 || row > garden.GetLength(0) || col < 0 || col > garden.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
