using System;
using System.Linq;

namespace P04.PizzaCalories
{
    class Program
    {
        static void Main()
        {
            try
            {
                string[] pizzaCmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] doughCmd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string pizzaName = pizzaCmd[1];

                string flourType = doughCmd[1];
                string flourTehnik = doughCmd[2];
                int grams = int.Parse(doughCmd[3]);
                Dough dough = new Dough(flourType, flourTehnik, grams);

                Pizza pizza = new Pizza(pizzaName, dough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string toppingType = input[1];
                    int toppingGrams = int.Parse(input[2]);
                    Topping topping = new Topping(toppingType, toppingGrams);
                    pizza.AddTopping(topping);

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{pizzaName} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }            
        }
    }
}
