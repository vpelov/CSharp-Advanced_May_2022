using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P07.SoftuniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regGuest = new HashSet<string>();
            HashSet<string> vipGuest = new HashSet<string>();

            string regPattern = @"[A-za-z0-9]{8}";
            string vipPattern = @"[0-9]{1}[A-za-z0-9]{7}";

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "PARTY")
                {
                    break;
                }

                Match vipNumber = Regex.Match(command, vipPattern);
                if (vipNumber.Success)
                {
                    vipGuest.Add(command);
                    continue;
                }
                
                Match regNumber = Regex.Match(command, regPattern);
                if (regNumber.Success)
                {
                    regGuest.Add(command);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                Match vipNumber = Regex.Match(command, vipPattern);                
                if (vipNumber.Success && vipGuest.Contains(command))
                {
                    vipGuest.Remove(command);
                    continue;
                }

                Match regNumber = Regex.Match(command, regPattern);
                if (regNumber.Success && regGuest.Contains(command))
                {
                    regGuest.Remove(command);
                }

            }
            int leftGuest = regGuest.Count + vipGuest.Count;
            Console.WriteLine(leftGuest);

            foreach (string item in vipGuest)
            {
                Console.WriteLine(item);
            }

            foreach (string item in regGuest)
            {
                Console.WriteLine(item);
            }

        }
    }
}
