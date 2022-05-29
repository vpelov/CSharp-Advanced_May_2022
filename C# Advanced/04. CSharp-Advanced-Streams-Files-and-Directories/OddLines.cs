using System.Collections.Generic;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int count = 0;
                    List<string> textList = new List<string>();
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        textList.Add(line);

                        line = reader.ReadLine();
                    }
                    foreach (var item in textList)
                    {
                        if (count % 2 != 0)
                        {
                            writer.WriteLine(item);
                        }
                        count++;
                    }
                }
            }
        }
    }
}

