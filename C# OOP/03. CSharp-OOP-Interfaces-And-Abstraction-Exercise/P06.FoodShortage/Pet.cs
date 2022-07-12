using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl
{
    public class Pet : IBirthdate, IName
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name
        { 
            get => this.name;
            set => this.name = value;
        }

        public string Birthdate 
        {
            get => this.birthdate;
            set => this.birthdate = value;
        }
    }
}
