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

            Console.WriteLine(String.Join("", stack));    // First var.

            //foreach (char ch in stack)   // Second var.
            //{
            //    Console.Write(ch);
            //}
        }
    }
}
