using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(); 
            string[] inData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string item in inData)
            {
                stack.Push(item);
            }

            while (stack.Count > 3)
            {
                int firstNum = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                string signTwo = stack.Pop();
                if (sign == "-" && signTwo == "-")
                {
                    int result = - secondNum - firstNum;
                    if (result >= 0)
                    {
                        stack.Push("+");
                        string back = result.ToString();
                        stack.Push(back);                                                
                    }
                    else if (result < 0)
                    {
                        stack.Push("-");
                        result = Math.Abs(result);
                        string back = result.ToString();
                        stack.Push(back);
                    }
                }
                else if (sign == "-" && signTwo == "+")
                {
                    int result = secondNum - firstNum;
                    if (result >= 0)
                    {
                        stack.Push("+");
                        string back = result.ToString();
                        stack.Push(back);
                    }
                    else if (result < 0)
                    {
                        stack.Push("-");
                        result = Math.Abs(result);
                        string back = result.ToString();
                        stack.Push(back);
                    }
                }
                else if (sign == "+" && signTwo == "-")
                {
                    int result = - secondNum + firstNum;
                    if (result >= 0)
                    {
                        stack.Push("+");
                        string back = result.ToString();
                        stack.Push(back);
                    }
                    else if (result < 0)
                    {
                        stack.Push("-");
                        result = Math.Abs(result);
                        string back = result.ToString();
                        stack.Push(back);
                    }
                }
                else if (sign == "+" && signTwo == "+")
                {
                    int result = secondNum + firstNum;
                    if (result >= 0)
                    {
                        stack.Push("+");
                        string back = result.ToString();
                        stack.Push(back);
                    }
                    else if (result < 0)
                    {
                        stack.Push("-");
                        result = Math.Abs(result);
                        string back = result.ToString();
                        stack.Push(back);
                    }
                }
            }

            int numOne = int.Parse(stack.Pop());
            string signs = stack.Pop();
            int numTwo = int.Parse(stack.Pop());
            if (signs == "-")
            {
                int result = numTwo - numOne;
                string back = result.ToString();
                stack.Push(back);
            }
            else if (signs == "+")
            {
                int result = numOne + numTwo;
                string back = result.ToString();
                stack.Push(back);
            }

            Console.WriteLine(string.Join(' ', stack));
           
        }
    }
}
