using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> peopleDict = new Dictionary<string, IBuyer>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] currentPeople = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (currentPeople.Length == 3)
                {
                    string name = currentPeople[0];
                    int age = int.Parse(currentPeople[1]);
                    string group = currentPeople[2];

                    IBuyer buyer = new Rebel(name, age, group);
                    peopleDict.Add(name, buyer);
                }
                else if (currentPeople.Length == 4)
                {
                    string name = currentPeople[0];
                    int age = int.Parse(currentPeople[1]);
                    string id = currentPeople[2];
                    string birthdate = currentPeople[3];

                    IBuyer buyer = new Citizen(name, age, id, birthdate);
                    peopleDict.Add(name, buyer);
                }
            }


            string command = Console.ReadLine();
            while (command != "End")
            {
                if (peopleDict.ContainsKey(command))
                {
                    peopleDict[command].BuyFood();
                }
                command = Console.ReadLine();
            }

            int totalFood = 0;

            foreach (var item in peopleDict)
            {
                totalFood += item.Value.Food;
            }


            Console.WriteLine(totalFood);
        }       
    }
}
