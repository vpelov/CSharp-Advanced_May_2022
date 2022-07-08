using System;
using System.Collections.Generic;
using System.Text;

namespace P03.ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        public List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public decimal Money
        {
            get { return this.money; } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                else
                {
                    this.money = value;
                }
            }
        }




        public void AddProduct(Product product)
        {
            this.bag.Add(product);
        }
    }
}
