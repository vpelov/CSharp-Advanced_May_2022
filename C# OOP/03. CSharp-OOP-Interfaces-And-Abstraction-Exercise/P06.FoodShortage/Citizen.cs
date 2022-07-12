using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl
{
    public class Citizen : IId, IBirthdate, IName, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        private const int additionalyFood = 10;


        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name 
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age 
        {
            get => this.age;
            set => this.age = value;
        }

        public string Id 
        {
            get => this.id;
            set => this.id = value;
        }

        public string Birthdate 
        {
            get => this.birthdate;
            set => this.birthdate = value; 
        }

        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            this.Food += additionalyFood;
        }
    }
}
