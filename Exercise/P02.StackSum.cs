using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numberStack = new Stack<int>();
             int[] inArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            foreach (int item in inArray)
            {
                numberStack.Push(item);
            }

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmd = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (cmd[0] == "add")
                {
                    numberStack.Push(int.Parse(cmd[1]));
                    numberStack.Push(int.Parse(cmd[2]));
                }
                else if (cmd[0] == "remove" && numberStack.Count > int.Parse(cmd[1]))
                {
                    int numberOut = int.Parse(cmd[1]);
                    for (int i = 0; i < numberOut; i++)
                    {
                        numberStack.Pop();
                    }
                }
            }

            int sum = numberStack.Sum();
            Console.WriteLine($"Sum: {sum}");


           // Console.WriteLine(String.Join('#', inArray));
        }
    }
}
