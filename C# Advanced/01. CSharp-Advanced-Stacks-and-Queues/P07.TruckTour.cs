using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numberPetrolPump = long.Parse(Console.ReadLine());
            Queue<Dictionary<long,long>> queueCircle = new Queue<Dictionary<long, long>>();
            for (int i = 0; i < numberPetrolPump; i++)
            {
                long[] pairs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
                long amountPetrol = pairs[0];
                long distance = pairs[1];
                Dictionary<long, long> currentPump = new Dictionary<long, long>();
                currentPump.Add(amountPetrol, distance);
                queueCircle.Enqueue(currentPump);
            }

            int count = 0;

            while (count < queueCircle.Count)
            {
                bool isIt = true;
                long amountPetrol = 0;
                long distance = 0;

                for (int i = 0; i < queueCircle.Count; i++)
                {                   
                    Dictionary<long, long> currentDict = queueCircle.Dequeue();
                    foreach (var item in currentDict)
                    {
                        amountPetrol += item.Key;
                        distance += item.Value;
                    }

                    if (amountPetrol < distance)
                    {                        
                        isIt = false;
                    }

                    queueCircle.Enqueue(currentDict);
                }
                                
                if (!isIt)
                {
                    count++;
                    Dictionary<long, long> rotateDict = queueCircle.Dequeue();
                    queueCircle.Enqueue(rotateDict);
                }
                else
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
