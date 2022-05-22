using System;
using System.Collections.Generic;

namespace P08.BalancedParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            Queue<char> charQueue = new Queue<char>();
            for (int i = 0; i < inputData.Length; i++)
            {
                char current = inputData[i];
                charQueue.Enqueue(current);
            }

            bool isOk = false;

            if (charQueue.Count % 2 != 0)
            {
                isOk = false;
            }
            else
            {
                while (charQueue.Count > 0)
                {

                    char first = '1';
                    char last = '2';
                    if (charQueue.Count == 2)
                    {
                        first = charQueue.Dequeue();
                        last = charQueue.Dequeue();
                    }
                    else
                    {

                        for (int i = 0; i < charQueue.Count; i++)
                        {
                            if (i == 0)
                            {
                                first = charQueue.Dequeue();
                            }
                            char circle = charQueue.Dequeue();
                            charQueue.Enqueue(circle);
                            if (i == charQueue.Count - 2)
                            {
                                last = charQueue.Dequeue();
                            }
                        }
                    }

                    if (first == '(' && last == ')' || first == '{' && last == '}' || first == '[' && last == ']')
                    {
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                        break;
                    }
                }
            }

            if (isOk)
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
