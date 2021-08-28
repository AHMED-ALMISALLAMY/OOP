using System;

namespace OOP_OverloadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.speak();
            cat.speak();
        }
    }


    class Animals 
    {
        public virtual void speak() 
        {
            Console.WriteLine("animal");
        }
    }

    class Dog : Animals
    {
        public override void speak() 
        {
            Console.WriteLine("Dog");
        }
    }

    class Cat : Animals
    {
        public override void speak() 
        {
            Console.WriteLine("Cat");
        }
    }
}
