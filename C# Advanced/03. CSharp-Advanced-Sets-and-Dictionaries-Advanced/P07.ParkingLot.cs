using System;
using System.Collections.Generic;

namespace P07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingCar = new HashSet<string>();
            string line = Console.ReadLine();
            while (line != "END")
            {
                string[] cmd = line.Split(", ");
                string action = cmd[0];
                string carNumber = cmd[1];

                if (action == "IN")
                {
                    parkingCar.Add(carNumber);
                }
                else if(action == "OUT")
                {
                    parkingCar.Remove(carNumber);
                }
                line = Console.ReadLine();
            }

            if (parkingCar.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parkingCar)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
