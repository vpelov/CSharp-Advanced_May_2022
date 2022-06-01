using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ReverseAndExclude
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int num = int.Parse(Console.ReadLine());

            Func<int, int, bool> isTrue = (x, y) => x % y == 0;

            numbers = numbers.Reverse().ToArray();
            List<int> printList = new List<int>();

            foreach (var item in numbers)
            {
                if (!isTrue(item, num))
                {
                    printList.Add(item);
                }
            }

            Console.WriteLine(String.Join(" ", printList));
        }
    }
}
