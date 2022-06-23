using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int value = int.Parse(Console.ReadLine());

            while (threads.Count != 0)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();

                if (value == task)
                {
                    tasks.Pop();
                    break;
                }
                else
                {
                    if (thread >= task)
                    {
                        threads.Dequeue();
                        tasks.Pop();
                        continue;
                    }
                    else
                    {
                        threads.Dequeue();
                    }
                }
            }

            Console.WriteLine($"Thread with value {threads.Peek()} killed task {value}");
            Console.Write($"{string.Join(" ", threads)} ");
        }
    }
}
