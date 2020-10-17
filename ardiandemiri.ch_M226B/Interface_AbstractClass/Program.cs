using System;

namespace Interface_AbstractClass
{
    class MainClass
    {
        //Just for testing reasons
        public static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.makeSound();
            tiger.run();
        }

        public abstract class Animal
        {
            // Method with no body
            public abstract void makeSound();

            // Method with body but not abstract
            public void run()
            {
                Console.WriteLine("running....");
            }
        }

        public class Tiger : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Tiger Sound...");
            }
        }
    }
}
