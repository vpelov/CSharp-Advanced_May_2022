using System;
using System.Collections.Generic;

namespace P01.Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (char item in str)
            {
                stack.Push(item);
            }

            foreach (char ch in stack)
            {
                Console.Write(ch);
            }
        }
    }
}
