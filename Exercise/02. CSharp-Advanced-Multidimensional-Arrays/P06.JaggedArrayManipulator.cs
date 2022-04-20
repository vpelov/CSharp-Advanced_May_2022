using System;
using System.Linq;

namespace P06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jaggedRows = int.Parse(Console.ReadLine());                      // Input Data
            int[][] jaggedArray = new int[jaggedRows][];

            for (int jaggedRow = 0; jaggedRow < jaggedArray.GetLength(0); jaggedRow++)
            {
                int[] inputData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();                

                jaggedArray[jaggedRow] = inputData;              

            }

            for (int rows = 1; rows < jaggedArray.GetLength(0); rows++)            // Work operation
            {
                if (jaggedArray[rows].Length == jaggedArray[rows - 1].Length)
                {
                    for (int i = 0; i < jaggedArray[rows ].Length; i++)
                    {
                        jaggedArray[rows][i] *= 2;
                        jaggedArray[rows - 1][i] *= 2;

                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArray[rows].Length; i++)
                    {
                        jaggedArray[rows][i] /= 2;
                    }

                    for (int j = 0; j < jaggedArray[rows - 1].Length; j++)
                    {
                        jaggedArray[rows - 1][j] /= 2;
                    }
                }
            }

            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] commands = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                if (command == "Add")
                {
                    int row = int.Parse(commands[1]);
                    int column = int.Parse(commands[2]);
                    int value = int.Parse(commands[3]);

                    if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                    {
                        jaggedArray[row][column] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(commands[1]);
                    int column = int.Parse(commands[2]);
                    int value = int.Parse(commands[3]);

                    if (row >= 0 && row < jaggedArray.GetLength(0) && column >= 0 && column < jaggedArray[row].Length)
                    {
                        jaggedArray[row][column] -= value;
                    }
                }               
                cmd = Console.ReadLine();
            }



            for (int i = 0; i < jaggedArray.GetLength(0); i++)              //Print output
            {
                Console.WriteLine(String.Join(" ", jaggedArray[i]));
            }

        }
    }
}
