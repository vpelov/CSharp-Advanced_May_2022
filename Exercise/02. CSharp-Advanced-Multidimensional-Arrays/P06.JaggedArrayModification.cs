using System;
using System.Linq;

namespace P06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nRows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[nRows][];

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedArr[i] = new int[currentArr.Length];
                jaggedArr[i] = currentArr;
            }

            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                string[] command = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row < jaggedArr.Length && row >= 0 && col < jaggedArr[row].Length && col >= 0)
                    {
                        jaggedArr[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row < jaggedArr.Length && row >= 0 && col < jaggedArr[row].Length && col >= 0)
                    {
                        jaggedArr[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                cmd = Console.ReadLine();
            }

            foreach (var item in jaggedArr)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
