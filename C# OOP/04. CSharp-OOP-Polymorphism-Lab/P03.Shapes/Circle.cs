using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        private const double Pi = 3.14;

        public override double CalculateArea()   
        {
           return Pi * (this.Radius * this.Radius);
        }

        public override double CalculatePerimeter() //2*pi*r
        {
            return 2 * Pi * this.Radius;
        }

        public override string Draw()
        {
            return base.Draw() + $" {this.GetType().Name}";
        }
    }
}
