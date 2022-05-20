using System;

namespace P07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] jaggedArray = new long[n][];
            jaggedArray[0] = new long[1] { 1 };

            for (int i = 1; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new long[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (j == 0)
                    {
                        jaggedArray[i][j] = 1;
                    }
                    else if (j == jaggedArray[i].Length - 1)
                    {
                        jaggedArray[i][j] = 1;
                    }
                    else
                    {
                        jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(String.Join(' ', jaggedArray[i]));
            }
        }
    }
}
