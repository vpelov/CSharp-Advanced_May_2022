using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> dataQueue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                dataQueue.Enqueue(currentArr);
            }
                        
            int index = 0;

            while (true)
            {
                int petrolAmaount = 0;

                foreach (int[] item in dataQueue)
                {
                    int currentPetrol = item[0];
                    int currentDistance = item[1];

                    petrolAmaount += currentPetrol;
                    petrolAmaount -= currentDistance;

                    if (petrolAmaount < 0)
                    {
                        int[] element = dataQueue.Dequeue();
                        dataQueue.Enqueue(element);
                        index++;
                        break;
                    }
                    
                }

                if(petrolAmaount >= 0 )
                {
                    Console.WriteLine(index);
                    break;
                }
               
            }





        }
    }
}
