using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model 
        { 
            get => this.model;
            set => model = value;
        }

        public string Color 
        { 
            get => this.color;
            set => this.color = value;
        }

        public string Start()
        {
            return $"Engine start";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }



        public override string ToString()
        {
            return $"{this.Color} {this.GetType().Name} {this.Model}";
            //return $"{this.Color} {nameof(Seat)} {this.Model}";
        }
    }
}
