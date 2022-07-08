using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                string[] inDataPerson = Console.ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                for (int i = 0; i < inDataPerson.Length; i++)
                {
                    string[] currPeople = inDataPerson[i]
                        .Split('=', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string name = currPeople[0];
                    decimal money = decimal.Parse(currPeople[1]);
                    Person person = new Person(name, money);
                    persons.Add(person);
                }

                string[] inDataProducts = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int i = 0; i < inDataProducts.Length; i++)
                {
                    string[] currProduct = inDataProducts[i]
                        .Split('=', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string productName = currProduct[0];
                    decimal cost = decimal.Parse(currProduct[1]);
                    Product product = new Product(productName, cost);
                    products.Add(product);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                if (ae.Message == "Money cannot be negative")
                {
                    return;
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] currentCommand = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = currentCommand[0];
                string product = currentCommand[1];
                Person currPerson = persons.First(p => p.Name == name);
                Product currProduct = products.First(p => p.Name == product);
                if (currPerson.Money >= currProduct.Cost)
                {
                    currPerson.AddProduct(currProduct);
                    currPerson.Money -= currProduct.Cost;
                    Console.WriteLine($"{currPerson.Name} bought {currProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} can't afford {currProduct.Name}");
                }
                command = Console.ReadLine();
            }

            foreach (Person person in persons)
            {
                if (person.bag.Count == 0 )
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.bag)}");
                }
            }

        }
    }
}
