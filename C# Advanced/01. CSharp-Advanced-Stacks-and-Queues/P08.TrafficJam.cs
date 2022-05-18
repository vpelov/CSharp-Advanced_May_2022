using System;
using System.Collections.Generic;

namespace P08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> carQueue = new Queue<string>();

            int passNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int passCount = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    if (carQueue.Count > passNumber)
                    {
                        for (int i = 0; i < passNumber; i++)
                        {
                            string passCar = carQueue.Dequeue();
                            Console.WriteLine($"{passCar} passed!");
                            passCount++;
                        }
                    }
                    else
                    {
                        while (carQueue.Count > 0)
                        {
                            string passCar = carQueue.Dequeue();
                            Console.WriteLine($"{passCar} passed!");
                            passCount++;
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{passCount} cars passed the crossroads.");
        }
    }
}
