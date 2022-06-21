using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var orcWarrior = new Stack<int>();
            var plates = new LinkedList<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            for (int i = 1; i <= n; i++)
            {
                if (!plates.Any() && i % 3 != 0)
                {
                    break;
                }
                orcWarrior = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
                if (i % 3 == 0)
                {
                    plates.AddLast(int.Parse(Console.ReadLine()));
                }

                while (plates.Any() && orcWarrior.Any())
                {
                    int orcPower = orcWarrior.Pop();
                    int plate = plates.First();
                    plates.RemoveFirst();
                    if (plate > orcPower)
                    {
                        plate -= orcPower;
                        plates.AddFirst(plate);

                    }
                    else if (plate < orcPower)
                    {
                        orcPower -= plate;
                        orcWarrior.Push(orcPower);
                    }
                }

                if (!plates.Any())
                {
                    break;
                }
            }

            Console.WriteLine(plates.Any()
                ? $"The people successfully repulsed the orc's attack.\nPlates left: {string.Join(", ", plates)}"
                : $"The orcs successfully destroyed the Gondor's defense.\nOrcs left: {string.Join(", ", orcWarrior)}");
        }
    }
}
