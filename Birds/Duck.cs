using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Duck : Bird, ISwimming, IFlying
    {
        public int NumOfEggs { get; private set; }

        public Duck(double weight, double length, int numOfEggs) : base(weight, length)
        {
            if (numOfEggs < 0)
            {
                throw new ArgumentException("Number of eggs can't be less than 0.");
            }
            NumOfEggs = numOfEggs;
        }

        public override string ToString()
        {
            string str;
            str = "Duck. Properties: " + base.ToString() + ", Number of eggs laid: " + NumOfEggs.ToString();

            return str;
        }

        public void swim()
        {
            Console.WriteLine("The duck swims and sings the krya-krya song.");
        }

        public void fly()
        {
            Console.WriteLine("The duck starts its flight into the stratosphere...");
        }
    }
}
