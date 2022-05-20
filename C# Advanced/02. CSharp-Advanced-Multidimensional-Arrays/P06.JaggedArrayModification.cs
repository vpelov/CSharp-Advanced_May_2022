using System;
using System.Linq;

namespace P06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                int[] currentArray = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[i] = new int[currentArray.Length];
                jaggedArray[i] = currentArray;
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] cmd = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if (row < 0 || row > jaggedArray.Length - 1 || col < 0 || col > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;

                }
                else if (cmd[0] == "Add")
                {                    
                    jaggedArray[row][col] += value;
                }
                else if (cmd[0] == "Subtract")
                {                    
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(String.Join(' ', jaggedArray[i]));
            }
        }
    }
}
