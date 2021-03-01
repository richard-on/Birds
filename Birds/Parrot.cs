using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Parrot : Bird, IFlying
    {
        public enum Colours { Red, Green, Blue, Other}
        Colours Colour { get; set; }

        public Parrot(double weight, double length, Colours colour) : base(weight, length)
        {
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
