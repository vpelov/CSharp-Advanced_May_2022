using System;

namespace P01.SquareRoot
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            try
            {
                double sqr = TakeSquare(num);
                Console.WriteLine(sqr);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        }

        public static double TakeSquare(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            double result = Math.Sqrt(num);
            return result;

        }
    }
}
