using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\input1.txt";
            var secondInputFilePath = @"..\..\..\input2.txt";
            var outputFilePath = @"..\..\..\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(firstInputFilePath))
            {
                using (StreamReader readerTwo = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string lineOne = reader.ReadLine();
                        string lineTwo = readerTwo.ReadLine();

                        while (lineOne != null && lineTwo != null)
                        {
                            writer.WriteLine(lineOne);
                            writer.WriteLine(lineTwo);

                            lineOne = reader.ReadLine();
                            lineTwo = readerTwo.ReadLine();

                            if (lineOne != null && lineTwo != null)
                            {
                                continue;
                            }
                            else
                            {
                                if (lineOne == null && lineTwo != null)
                                {
                                    while (lineTwo != null)
                                    {
                                        writer.Write(lineTwo);
                                        lineTwo = readerTwo.ReadLine();
                                    }
                                }
                                else if (lineOne != null && lineTwo == null)
                                {
                                    while (lineOne != null)
                                    {
                                        writer.Write(lineOne);
                                        lineOne = reader.ReadLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}

