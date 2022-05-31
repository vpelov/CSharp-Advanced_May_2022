using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FilterByAge
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            listPerson = ReadPerson();

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string whatPrint = Console.ReadLine();

            Func<Person, bool> filter = primeryFilter(condition, age);

            List<Person> printList = listPerson.Where(filter).ToList();

            Action<Person> printPersonSet = PersonPrint(whatPrint);

            foreach (var item in printList)
            {
                printPersonSet(item);
            }
        }

       

        static List<Person> ReadPerson()
        {
            List<Person> newList = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] current = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = current[0];
                int age = int.Parse(current[1]);
                Person curr = new Person();
                curr.Name = name;
                curr.Age = age;
                newList.Add(curr);                
            }
            return newList;
        }


        static Func<Person, bool> primeryFilter(string condition, int age)
        {            
            if (condition == "younger")
                return p => p.Age < age;
            if (condition == "older")
                return p => p.Age >= age;
            throw new ArgumentException($"Invalid: {condition} {age}");
        }

        static Action<Person> PersonPrint(string whatPrint)
        {
            if (whatPrint == "name age")
                return (Person p) => Console.WriteLine($"{p.Name} - {p.Age}");
            if (whatPrint == "age")
                return (Person x) => Console.WriteLine($"{x.Age}");
            if (whatPrint == "name")
                return (Person y) => Console.WriteLine($"{y.Name}");
            throw new ArgumentException($"Invalid: {whatPrint}");
        }
    }
}
