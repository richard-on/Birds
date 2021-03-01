using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Parrot : Bird, IFlying
    {
        public string Colour { get; private set; }

        public Parrot(double weight, double length, string colour) : base(weight, length)
        {
            if(string.IsNullOrEmpty(colour))
            {
                throw new ArgumentException("Specify the colour.");
            }
            Colour = colour;
        }

        public override string ToString()
        {
            string str;
            str = "Parrot. Properties: " + base.ToString() + ", Colour: " + Colour.ToString();

            return str;
        }

        public void fly()
        {
            Console.WriteLine("The parrot starts flying, but soon finds out he cannot escape Kashkevich's house :(");
        }
    }
}
