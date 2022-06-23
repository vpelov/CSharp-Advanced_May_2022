using System;
using System.Linq;

namespace P02.Survivor
{
    class Program
    {
        private static int collectMyTokens = 0;
        private static int collectOpponentTokens = 0;
        private static char[][] beach;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            beach = new char[n][];
            for (int i = 0; i < beach.GetLength(0); i++)
            {
                char[] currArr = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                beach[i] = currArr;
            }

            string[] line = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string command = line[0];
                if (command == "Gong")
                {
                    break;
                }

                int row = int.Parse(line[1]);
                int col = int.Parse(line[2]);

                if (command == "Find")
                {

                    if (IsRealCoordinates(row, col) && beach[row][col] == 'T')
                    {
                        collectMyTokens++;
                        beach[row][col] = '-';
                    }
                }
                else if (command == "Opponent")
                {
                    string direction = line[3];
                    OpponentMove(row, col, direction);

                }

                line = Console.ReadLine().Split().ToArray();
            }

            for (int i = 0; i < beach.Length; i++)
            {
                Console.WriteLine(string.Join(' ', beach[i]));
            }

            Console.WriteLine($"Collected tokens: {collectMyTokens}");
            Console.WriteLine($"Opponent's tokens: {collectOpponentTokens}");

        }

        private static void OpponentMove(int row, int col, string direction)
        {
            if (IsRealCoordinates(row, col) && beach[row][col] == 'T')
            {
                collectOpponentTokens++;
                beach[row][col] = '-';
            }

            if (direction == "up")
            {
                for (int i = 0; i < 3; i++)
                {
                    row -= 1;
                    if (IsRealCoordinates(row, col) && beach[row][col] == 'T')
                    {
                        collectOpponentTokens++;
                        beach[row][col] = '-';
                    }
                }
            }
            else if (direction == "down")
            {
                for (int i = 0; i < 3; i++)
                {
                    row += 1;
                    if (IsRealCoordinates(row, col) && beach[row][col] == 'T')
                    {
                        collectOpponentTokens++;
                        beach[row][col] = '-';
                    }
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < 3; i++)
                {
                    col += 1;
                    if (IsRealCoordinates(row, col) && beach[row][col] == 'T')
                    {
                        collectOpponentTokens++;
                        beach[row][col] = '-';
                    }
                }
            }
            else if (direction == "left")
            {
                for (int i = 0; i < 3; i++)
                {
                    col -= 1;
                    if (IsRealCoordinates(row, col) && beach[row][col] == 'T')
                    {
                        collectOpponentTokens++;
                        beach[row][col] = '-';
                    }
                }
            }
        }

        private static bool IsRealCoordinates(int row, int col)
        {
            if (row >= 0 && row < beach.Length && col >= 0 && col < beach[row].Length)
            {
                return true;
            }
            return false;
        }
    }
}
