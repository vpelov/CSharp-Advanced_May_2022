using System;
using System.Linq;

namespace P04.SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;

            string[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                string current = numbers[i];

                try
                {
                    int result = int.Parse(current);
                    totalSum += result;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{current}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{current}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{current}' processed - current sum: {totalSum}");
                }

            }

            Console.WriteLine($"The total sum of all integers is: {totalSum}");
        }
    }
}
