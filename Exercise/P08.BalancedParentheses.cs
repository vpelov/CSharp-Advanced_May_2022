using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine()
                .ToCharArray();
            Stack<char> data = new Stack<char>();


            foreach (char item in charArray)
            {
                if (data.Any())
                {

                    if (item == '(' || item == '{' || item == '[')
                    {
                        data.Push(item);
                    }
                    else if (item == ')')
                    {
                        char currentChar = data.Peek();
                        if (currentChar == '(')
                        {
                            data.Pop();
                        }
                    }
                    else if (item == ']')
                    {
                        char currentChar = data.Peek();
                        if (currentChar == '[')
                        {
                            data.Pop();
                        }
                    }
                    else if (item == '}')
                    {
                        char currentChar = data.Peek();
                        if (currentChar == '{')
                        {
                            data.Pop();
                        }
                    }
                }
                else
                {
                    data.Push(item);                    
                }
            }
            

            if (data.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
