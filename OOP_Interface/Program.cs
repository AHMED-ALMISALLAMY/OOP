using System;

namespace OOP_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabit rabit = new Rabit(); 
            rabit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt(); 

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();
        }
    }


    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }


    class Rabit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The Rabit Runs Away!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The Hawk was Searching For Food!"); 
        }
    }

    class Fish : IPrey , IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The Fish Runs Away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The Fish was Searching For Food!"); 
        }
    }
}
