using System;
using System.Collections.Generic;

namespace P08.SoftuniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regularGuest = new HashSet<string>();
            var vipGuest = new HashSet<string>();
            string line = Console.ReadLine();
            while (line != "PARTY")
            {
                if (isDigit(line[0]))
                {
                    vipGuest.Add(line);
                }
                else
                {
                    regularGuest.Add(line);
                }
                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            while (line != "END")
            {
                if (isDigit(line[0]))
                {
                    vipGuest.Remove(line);
                }
                else
                {
                    regularGuest.Remove(line);
                }
                line = Console.ReadLine();
            }

            int allGuest = vipGuest.Count + regularGuest.Count;
            Console.WriteLine(allGuest);
            foreach (var vipPerson in vipGuest)
            {
                Console.WriteLine(vipPerson);
            }
            foreach (var person in regularGuest)
            {
                Console.WriteLine(person);
            }

        }

        static bool isDigit(char v)
        {
            bool isDigit = true;
            if (v >= 48 && v <= 57)
            {
                isDigit = true;
            }
            else
            {
                isDigit = false;
            }
            return isDigit;
        }
    }
}
