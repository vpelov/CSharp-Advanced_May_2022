using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\words.txt";
            string textPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> store = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                string searchWords = reader.ReadToEnd().ToLower();

                using (StreamReader readText = new StreamReader(textFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string currentText = readText.ReadToEnd().ToLower();
                        string[] words = searchWords.Split(' ').ToArray();
                        string[] text = currentText.Split(new char[] {' ', ',', '.', '-' }).ToArray();

                        foreach (var word in words)
                        {
                            foreach (var item in text)
                            {
                                if (word == item)
                                {
                                    if (!store.ContainsKey(word))
                                    {
                                        store.Add(word, 1);
                                    }
                                    else
                                    {
                                        store[word]++;
                                    }
                                }
                            }
                        }

                        foreach (var item in store.OrderByDescending(x => x.Value))
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
            

        }
    }
}

