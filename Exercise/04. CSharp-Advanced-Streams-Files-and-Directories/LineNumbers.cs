using System;
using System.IO;

namespace RewriteFileWithLineNumbers
{
    internal class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"input.txt";
            string outputFilePath = @"output.txt";

            ReWriteFile(inputFilePath, outputFilePath);
        }

        static void ReWriteFile(string inputFilePath, string outputfilePath)
        {
            using (StreamWriter sw = new StreamWriter(outputfilePath))
            {
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    string line = sr.ReadLine();
                    int count = 1;
                    while (line != null)
                    {
                        sw.WriteLine($"{count}. {line}");
                        count++;
                        line = sr.ReadLine();
                    }
                }
            }
        }
    }
}


