using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P06.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> data = new HashSet<string>();

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "END")
                {
                    break;
                }

                string[] command = cmd.Split(", ");
                string move = command[0];
                string number = command[1];

                string pattern = @"[A-Z]{1,2}[1-9]{4}[A-Z]{2}";

                Match match = Regex.Match(number, pattern);

                if (match.Success)
                {
                    if (move == "IN")
                    {
                        data.Add(number);
                    }
                    else if(move == "OUT")
                    {
                        data.Remove(number);
                    }
                }
            }

            if (data.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (string item in data)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
