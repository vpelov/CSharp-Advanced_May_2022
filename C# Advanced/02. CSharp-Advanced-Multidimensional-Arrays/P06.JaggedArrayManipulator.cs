using System;
using System.Linq;

namespace P06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[i] = currentArray;
            }

            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i +1].Length)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] *= 2;
                        jaggedArray[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] /= 2;                        
                    }

                    for (int k = 0; k < jaggedArray[i + 1].Length; k++)
                    {
                        jaggedArray[i + 1][k] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArray = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmd = cmdArray[0];
                int row = int.Parse(cmdArray[1]);
                int col = int.Parse(cmdArray[2]);
                int value = int.Parse(cmdArray[3]);

                if (cmd == "Add" && row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    jaggedArray[row][col] += value;
                }
                else if (cmd == "Subtract" && row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"{string.Join(' ', jaggedArray[i])}");
            }
        }
    }
}
