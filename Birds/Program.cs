using System;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kiwi kiwi_1 = new Kiwi(13, 13, 25);
                Console.WriteLine(kiwi_1);

                Duck duck_1 = new Duck(13, 13, 3);
                Console.WriteLine(duck_1);
                CheckFlySwim(duck_1);

                Penguin penguin_1 = new Penguin(13, 13, false);
                Console.WriteLine(penguin_1);
                penguin_1.swim();

                Parrot parrot_1 = new Parrot(13, 13, Parrot.Colours.Red);
                Console.WriteLine(parrot_1);
                
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void CheckFlySwim(Bird bird)
        {
            if(bird is IFlying)
            {
                (bird as IFlying).fly();
            }
            else
            {
                Console.WriteLine("This bird can't fly.");
            }

            if (bird is ISwimming)
            {
                (bird as ISwimming).swim();
            }
            else
            {
                Console.WriteLine("This bird can't swim.");
            }
        }
    }
}
