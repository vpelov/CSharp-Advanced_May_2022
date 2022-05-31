using System;
using System.Linq;

namespace P03.CountUppercaseWords
{
    internal class Program
    {
        static Func<string, bool> isUpperCase = (x) => char.IsUpper(x[0]);

        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isUpperCase(x))));
        }

    }
}
