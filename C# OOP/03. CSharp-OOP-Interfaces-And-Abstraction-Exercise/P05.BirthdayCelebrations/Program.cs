using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IBirthdate> enterList = new List<IBirthdate>();
            List<Robot> robots = new List<Robot>();
            IBirthdate iname;

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmd = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = cmd[0];

                if (cmd[0] == "Citizen")
                {
                    string name = cmd[1];
                    int age = int.Parse(cmd[2]);
                    string id = cmd[3];
                    string birthdate = cmd[4];

                    iname = new Citizen(name, age, id, birthdate);
                    enterList.Add(iname);
                }
                else if (cmd[0] == "Pet")
                {
                    string name = cmd[1];                    
                    string birthdate = cmd[2];

                    iname = new Pet(name, birthdate);
                    enterList.Add(iname);
                }
                else if (cmd[0] == "Robot")
                {
                    string name = cmd[1];
                    string birthdate = cmd[2];

                    Robot robot = new Robot(name, birthdate);
                    robots.Add(robot);
                }
                command = Console.ReadLine();
            }

            string searchNumber = Console.ReadLine();
            List<string> resultList = new List<string>();

            resultList = enterList.Where(x => x.Birthdate.EndsWith(searchNumber)).Select(x => x.Birthdate).ToList();

           
                foreach (string num in resultList)
                {
                    Console.WriteLine(num);
                }
           
            

           
        }       
    }
}
