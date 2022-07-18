using System;
using System.Collections.Generic;

namespace P02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> resultList = new List<string>();

            int start = 1;
            int end = 100;
            while (resultList.Count < 10)
            {
                string number = Console.ReadLine();

                try
                {
                    if (ReadNumber(number, start, end))
                    {
                        resultList.Add(number);
                        start = int.Parse(number);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }              

            }

            Console.WriteLine(string.Join(", ", resultList));

        }

        public static bool ReadNumber(string number, int start, int end)
        {
            if (!int.TryParse(number, out int result))
            {
                throw new ArgumentException("Invalid Number!");
            }

            if (result <= start || result >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }
            return true;
        }

    }
}
