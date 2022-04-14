using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] controlDigits = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = controlDigits[0];
            int s = controlDigits[1];
            int x = controlDigits[2];

            Queue<int> queueNumbers = new Queue<int>();

            string number = Console.ReadLine();
            int[] numbers = number
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                queueNumbers.Enqueue(numbers[i]);
            }

            if (queueNumbers.Count < s)
            {
                s = queueNumbers.Count;
            }

            for (int i = 0; i < s; i++)
            {
                queueNumbers.Dequeue();
            }

            if (queueNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queueNumbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queueNumbers.Min());
            }
        }
    }
}
