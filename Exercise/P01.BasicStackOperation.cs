using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] controlArray = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int n = controlArray[0]; //numbers digits in stack
            int s = controlArray[1]; // numbers Pop
            int x = controlArray[2]; // chek for that digits in stack

            int[] workDigits = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> workStack = new Stack<int>();
            foreach (int item in workDigits)
            {
                workStack.Push(item);
            }

            if (workStack.Count <= s)
            {
                s = workStack.Count;
            }

            for (int i = 0; i < s; i++)
            {
                workStack.Pop();
            }

            if (workStack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(workStack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{workStack.Min()}");
            }


        }
    }
}
