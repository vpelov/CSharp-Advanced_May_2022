using System;
using System.Collections.Generic;

namespace P01.WorkingWithStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char item in input)
            {
                stack.Push(item);
            }

            foreach (char item in stack)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            
        }
    }
}
