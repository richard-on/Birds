using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    abstract class Bird
    {
        public double Weight { get; private set; }
        public double Length { get; private set; }
        public Bird(double weight, double length)
        {
            if(weight <= 0 || length <= 0)
            {
                throw new ArgumentException("Weigth or length is incorrect.");
            }
            Weight = weight;
            Length = length;
        }

        public override string ToString()
        {
            string str;
            str = "Weight: " + Weight.ToString() + ", Length: " + Length.ToString();

            return str;
        }

    }
}
