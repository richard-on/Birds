using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Penguin : Bird, ISwimming
    {
        public bool FromMadagascar { get; private set; }

        public Penguin(double weight, double length, bool fromMadagascar) : base(weight, length)
        {
            FromMadagascar = fromMadagascar;
        }

        public override string ToString()
        {
            string str;
            str = "Penguin. Properties: " + base.ToString() + ", Is he from Madagascar: "; //+ FromMadagascar.ToString();
            if(FromMadagascar == true)
            {
                str += "Yes, this penguin is from Madagascar. He's almost like the usual one, except he can speak and use firearms. Be aware!";
            }
            else
            {
                str += "No, this is usual penguin. Nothing really special. BOOORING!";
            }

            return str;
        }

        public void swim()
        {
            Console.WriteLine("The penguin dives deep into the ocean to find food, but only finds Armenians playing backgammon.");
        }
    }
}
