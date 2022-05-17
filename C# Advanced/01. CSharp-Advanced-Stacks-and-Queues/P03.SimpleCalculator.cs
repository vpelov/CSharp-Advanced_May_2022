using System;
using System.Collections.Generic;

namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split(' '));

            //int totalSum = 0;

            while (stack.Count > 3)
            {
                int firstNum = int.Parse(stack.Pop());
                string signFirst = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                string signSecond = stack.Peek();
                if (signFirst == "-" && signSecond == "-")
                {
                    int currentNum = firstNum + secondNum;
                    if (currentNum < 0)
                    {
                        stack.Pop();
                        stack.Push("-");
                    }
                    string number = currentNum.ToString();
                    stack.Push(number);
                }
                else if (signFirst == "+" && signSecond == "-")
                {
                    int currentNum = firstNum - secondNum;
                    if (currentNum < 0)
                    {
                        stack.Pop();
                        stack.Push("-");
                    }
                    string number = currentNum.ToString();
                    stack.Push(number);
                }
                else if (signFirst == "-" && signSecond == "+")
                {
                    int currentNum = secondNum - firstNum;
                    if (currentNum < 0)
                    {
                        stack.Pop();
                        stack.Push("-");
                    }
                    string number = currentNum.ToString();
                    stack.Push(number);
                }
                else if (signFirst == "+" && signSecond == "+")
                {
                    int currentNum = firstNum + secondNum;
                    if (currentNum < 0)
                    {
                        stack.Pop();
                        stack.Push("-");
                    }
                    string number = currentNum.ToString();
                    stack.Push(number);
                }

            }

            int numberOne = int.Parse(stack.Pop());
            string sign = stack.Pop();
            int numberTwo = int.Parse(stack.Pop());

            int total = 0;
            if (sign == "+")
            {
                total = numberOne + numberTwo;
            }
            else
            {
                total = numberTwo - numberOne;
            }

            Console.WriteLine(total);
        }
    }
}
