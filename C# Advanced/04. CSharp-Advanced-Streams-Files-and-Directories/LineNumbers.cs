using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int count = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string newLine = $"{count}. {line}";
                        writer.WriteLine(newLine);
                        count++;
                        line = reader.ReadLine();
                    }

                }
            }
        }
    }
}

