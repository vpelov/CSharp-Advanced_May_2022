using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    class Topping
    {
        private readonly Dictionary<string, double> toppingType = new Dictionary<string, double>()
        {
            { "meat", 1.2},
            { "veggies", 0.8},
            { "cheese", 1.1},
            { "sauce", 0.9}
        };

        private const double caloriesPerGram = 2;

        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        public string Type 
        { 
            get => type;
            set
            {
                if (toppingType.ContainsKey(value.ToLower()))
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public double Grams
        { 
            get => grams;
            set
            {
                if (value >= 1 && value <= 50)
                {
                    this.grams = value;
                }
                else
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }
            }
        }


        public double CaloriesTopping()
        {
            return caloriesPerGram * toppingType[this.type.ToLower()] * this.grams;
        }
    }
}
