using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCarPass = int.Parse(Console.ReadLine());

            Queue<string> carQueue = new Queue<string>();
            int count = 0;

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < numberCarPass; i++)
                    {
                        if (carQueue.Count > 0)
                        {
                            string currentCar = carQueue.Dequeue();
                            Console.WriteLine($"{currentCar} passed!");
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(command);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
