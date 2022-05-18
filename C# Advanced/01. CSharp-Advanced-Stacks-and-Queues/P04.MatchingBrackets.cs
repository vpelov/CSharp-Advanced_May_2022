using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string data = Console.ReadLine();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '(')
                {
                    stack.Push(i);
                }
                else if (data[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    Console.WriteLine(data.Substring(startIndex, endIndex - startIndex + 1));
                }
            }
        }
    }
}
