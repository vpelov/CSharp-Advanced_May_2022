using System;
using System.Collections.Generic;
using System.Text;

namespace P01.ClassBoxData
{
    class Box
    {

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length 
        {
            get { return this.length; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public double SurfaceArea()
        {
            double result = ((this.Height * this.Length) + (this.Height * this.Width) + (this.Length * this.Width)) * 2;
            return result;
        }


        public double LateralSurfaceArea()
        {
            double result = ((this.Height * this.length) + (this.Height * this.Width)) * 2;
            return result;
        }

        public double Volume()
        {
            return this.Height * this.Width * this.Length;
        }

    }
}
