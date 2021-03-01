using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Kiwi : Bird
    {
        public double MaxRunningSpeed { get; private set; }

        public Kiwi(double weight, double length, double maxRunningSpeed) : base(weight, length)
        {
            if (maxRunningSpeed <= 0)
            {
                throw new ArgumentException("maxRunningSpeed is incorrect.");
            }
            MaxRunningSpeed = maxRunningSpeed;
        }
        public override string ToString()
        {
            string str;
            str = "Kiwi. Properties: " + base.ToString() + ", Max Running speed: " + MaxRunningSpeed.ToString();

            return str;
        }


    }
}