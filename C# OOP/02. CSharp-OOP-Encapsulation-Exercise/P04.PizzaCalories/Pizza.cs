using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.PizzaCalories
{
    class Pizza
    {
        private string name;

        

        public Dough Dough { get; set; }

        private readonly List<Topping> toppingsList;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppingsList = new List<Topping>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 1 && value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public IReadOnlyCollection<Topping> ToppingsList => toppingsList;

        private int toppingsNumber => this.toppingsList.Count;

        public double TotalCalories => Dough.Calories() + toppingsList.Sum(p => p.CaloriesTopping());

            
        public void AddTopping(Topping topping)
        {
            if (toppingsNumber > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            else
            {
                toppingsList.Add(topping);
            }
        }
    }
}
