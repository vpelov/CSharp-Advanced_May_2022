using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmd = command
                    .ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (cmd[0] == "add")
                {
                    int first = int.Parse(cmd[1]);
                    int second = int.Parse(cmd[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else if (cmd[0] == "remove")
                {
                    int number = int.Parse(cmd[1]);

                    if (stack.Count >= number)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            int totalSum = 0;

            while (stack.Count > 0)
            {
                int num = stack.Pop();
                totalSum += num;
            }

            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
