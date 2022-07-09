using System;
using System.Collections.Generic;

namespace P04.PizzaCalories
{
    public class Dough 
    {

        private readonly Dictionary<string, double> flourType = new Dictionary<string, double>()
        {
            {"white", 1.5 },
            {"wholegrain", 1.0 }
        };

        private readonly Dictionary<string, double> tehnology = new Dictionary<string, double>()
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private const double coloriesPerGram = 2;

        private string flour;
        private string bakingTehnology;
        private int weigh;

        public Dough(string flour, string bakingTehnology, int weigh)
        {
            this.Flour = flour.ToLower();
            this.BakingTehnology = bakingTehnology.ToLower();
            this.Weigh = weigh;
        }

        public int Weigh 
        {
            get => this.weigh; 
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                else
                {
                    this.weigh = value;
                }
            }
        }

        public string Flour 
        {
            get => flour;
            set
            {
                if (!this.flourType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                {
                    this.flour = value;
                }
            }
        }
        
        public string BakingTehnology 
        { 
            get => bakingTehnology;
            set 
            {
                if (!this.tehnology.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                else
                {
                    this.bakingTehnology = value;
                }
            }
        }

        public double Calories()
        {
            double result =  this.weigh * coloriesPerGram * flourType[this.flour] * tehnology[this.bakingTehnology];
            return result;
        }
    }
}