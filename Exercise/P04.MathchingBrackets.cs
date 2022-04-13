using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.MathchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inData = Console.ReadLine();
            char[] chArray = inData.ToCharArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < chArray.Length; i++)
            {
                if (chArray[i] == '(')
                {
                    int startIndex = i;
                    stack.Push(startIndex);
                }
                else if (chArray[i] == ')')
                {
                    int endIndex = i;
                    int startIndex = stack.Pop();
                    Console.WriteLine(inData.Substring(startIndex, endIndex - startIndex + 1));
                }
            }        
        }
    }
}
