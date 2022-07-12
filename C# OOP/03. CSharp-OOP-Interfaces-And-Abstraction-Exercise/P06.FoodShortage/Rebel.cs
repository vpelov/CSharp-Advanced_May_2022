using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl
{
    class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        private const int additionalyFood = 5;

        public string Name { get; set; }

        public int Age { get; set; }

        public string Group { get; set; }


        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            this.Food += additionalyFood;
        }
    }
}
