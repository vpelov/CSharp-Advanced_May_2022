using System;
using System.Linq;

namespace P03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] urlAdrres = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            foreach (string phone in phoneNumber)
            {
                bool IsLetter = false;

                foreach (char ch in phone)
                {
                    if (char.IsLetter(ch))
                    {
                        IsLetter = true;
                        break;
                    }
                }

                if (IsLetter)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                if (phone.Length == 10)
                {                  
                    Smartphone smartphone = new Smartphone(phone);
                    Console.WriteLine(smartphone.Calling()); 
                }
                else if (phone.Length == 7)
                {
                    StationaryPhone stationary = new StationaryPhone(phone);
                    Console.WriteLine(stationary.Dial()); 
                }
            }


            foreach (string url in urlAdrres)
            {
                if (url.Any(x => Char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else 
                {
                    Smartphone smartphone = new Smartphone(url);
                    Console.WriteLine(smartphone.Browsing()); 
                }
            }

        }
    }
}
