using System;
using System.Linq;

namespace P04.AddVAT
{
    internal class Program
    {
        static Func<double, double> costWithVAT = x => x * 1.20;

        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join("\n", Console.ReadLine()
            //    .Split(", ")
            //    .Select(double.Parse)
            //    .Select(x => costWithVAT(x))
            //    .ToArray()));

            double[] inputData = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => costWithVAT(x))
                .ToArray();

            foreach (var item in inputData)
            {
                Console.WriteLine($"{item:f2}");
            }

        }
    }
}
