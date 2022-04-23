using System;
using System.IO;
using System.Text;

namespace P01.OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"input.txt"))
            {
                int count = 0;
                var line = reader.ReadLine();

                while (line != null)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
