namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            int count = 1;
            string line = reader.ReadLine();
            string printLine = string.Empty;
            while(line != null)
            {
                int countLetters = line.Count(char.IsLetter);
                int countPunctuation = line.Count(char.IsPunctuation);
                string newLine = $"Line {count}: {line} ({countLetters}) ({countPunctuation}) \n";

                printLine += newLine;

                count++;
                line = reader.ReadLine();
            }

            File.WriteAllText(outputFilePath, printLine);
        }
    }
}