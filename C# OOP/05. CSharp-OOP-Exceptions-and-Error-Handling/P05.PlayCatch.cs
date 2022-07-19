using System;
using System.Linq;

namespace P05.PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int exeption = 0;

            while (exeption != 3)
            {
                string[] cmd = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


                try
                {
                    string command = cmd[0];

                    if (command == "Replace")
                    {
                        int index = int.Parse(cmd[1]);
                        int element = int.Parse(cmd[2]);
                        numbers[index] = element;
                    }
                    else if (command == "Print")
                    {
                        int startIndex = int.Parse(cmd[1]);
                        int endIndex = int.Parse(cmd[2]);
                        int[] printArr = new int[endIndex - startIndex + 1];
                        Array.Copy(numbers, startIndex, printArr, 0, printArr.Length);
                        Console.WriteLine(string.Join(", ", printArr));
                    }
                    else if (command == "Show")
                    {
                        int index = int.Parse(cmd[1]);
                        Console.WriteLine(numbers[index]);
                    }
                }
                catch (FormatException)
                {
                    exeption++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
                catch (ArgumentException)
                {
                    exeption++;
                    Console.WriteLine("The index does not exist!");
                }
                catch (IndexOutOfRangeException)
                {
                    exeption++;
                    Console.WriteLine("The index does not exist!");
                }
            }

            Console.WriteLine(String.Join(", ", numbers));

        }
    }
}
