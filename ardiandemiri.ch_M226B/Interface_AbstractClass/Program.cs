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

    // By default, members of an interface are abstract and public
    public interface IAnimal
    {
        // Interface classes can only contain
        // abstract methods and properties (no fields). 
        void makeSound();
        void run();
    }

    // When to use Interface?
    /* Why And When To Use Interfaces?

    1) To achieve security - hide certain details and only show the important details of an object (interface).

    2) C# does not support "multiple inheritance"
    (a class can only inherit from one base class). However,
    it can be achieved with interfaces, because the class can implement multiple
    interfaces. Note: To implement multiple interfaces,
    separate them with a comma (see example below).
    */

    interface IOtherAnimal
    {
        void jump();
    }

    // Multiple Interface implemented
    class Cat : IAnimal, IOtherAnimal
    {
        public void run()
        {
            Console.WriteLine("running..");
        }

        public void makeSound()
        {
            Console.WriteLine("Miauu....");
        }

        public void jump()
        {
            Console.WriteLine("jumping...");
        }
    }
}
