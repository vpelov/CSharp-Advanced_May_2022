using System;

namespace P02.TruffeleHunter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] charArr = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (char)charArr[j];
                }
            }


            int blackTruffleCount = 0;
            int summeTruffleCount = 0;
            int whiteTruffleCount = 0;
            int wildBoarCount = 0;

            string line = Console.ReadLine();
            while (line != "Stop the hunt")
            {
                string command = line.Split()[0];
                int row = int.Parse(line.Split()[1]);
                int col = int.Parse(line.Split()[2]);

                if (command == "Collect")
                {
                    if (matrix[row, col] == 'B')
                    {
                        blackTruffleCount++;
                        matrix[row, col] = '-';
                    }
                    else if (matrix[row, col] == 'S')
                    {
                        summeTruffleCount++;
                        matrix[row, col] = '-';
                    }
                    else if (matrix[row, col] == 'W')
                    {
                        whiteTruffleCount++;
                        matrix[row, col] = '-';
                    }
                }
                else if (command == "Wild_Boar")
                {
                    string direction = line.Split()[3];

                    switch (direction)
                    {
                        case "up":
                            for (int i = row; i >= 0; i-=2)
                            {
                                for (int j = col; j <= col; j++)
                                {
                                    if (matrix[i, j] != '-')
                                    {
                                        matrix[i, j] = '-';
                                        wildBoarCount++;
                                    }
                                }
                            }
                            break;
                        case "down":
                            for (int i = row; i < matrix.GetLength(0); i += 2)
                            {
                                for (int j = col; j <= col; j++)
                                {
                                    if (matrix[i, j] != '-')
                                    {
                                        matrix[i, j] = '-';
                                        wildBoarCount++;
                                    }
                                }
                            }
                            break;
                        case "left":
                            for (int i = row; i <= row; i++)
                            {
                                for (int j = col; j >= 0; j-=2)
                                {
                                    if (matrix[i, j] != '-')
                                    {
                                        matrix[i, j] = '-';
                                        wildBoarCount++;
                                    }
                                }
                            }
                            break;
                        case "right":
                            for (int i = row; i <= row; i++)
                            {
                                for (int j = col; j < matrix.GetLength(1); j += 2)
                                {
                                    if (matrix[i, j] != '-')
                                    {
                                        matrix[i, j] = '-';
                                        wildBoarCount++;
                                    }
                                }
                            }
                            break;
                    }
                }
                line = Console.ReadLine();
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffleCount} black, {summeTruffleCount} summer, and {whiteTruffleCount} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildBoarCount} truffles.");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
