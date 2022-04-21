using System;
using System.Collections.Generic;

namespace P05.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<int> sequenseNumber = new HashSet<int>();
            int number = 234;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!sequenseNumber.Contains(num))
                {
                    sequenseNumber.Add(num);
                }
                else
                {
                    number = num;
                }
            }

            if (number != 234)
            {
                Console.WriteLine(number);
            }
        }
    }
}
