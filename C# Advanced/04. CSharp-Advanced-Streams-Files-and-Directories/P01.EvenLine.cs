using System;
using System.IO;
using System.Linq;

namespace P01.EvenLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\pto\Desktop\C\C# Advanced May 2022\C# Advanced - май 2022\04. CSharp-Advanced-Streams-Files-and-Directories\text.txt";
            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }

                    count++;
                    line = reader.ReadLine();
                }
            }
        }

        static string Reverse(string line)
        {
            string[] arr = line.Split(' ').ToArray();
            arr = arr.Reverse().ToArray();
            string newLine = string.Join(' ', arr);
            return newLine;
        }


        static string Replace(string line)
        {
            return line.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@');
        }
    }
}
