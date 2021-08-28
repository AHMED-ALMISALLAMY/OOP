using System;

namespace OOP_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat();

            Vehicle[] Vehicles = {car , boat};

            foreach (Vehicle vehicle in Vehicles)
            {
                vehicle.go();
            }
        }
    }

    class Vehicle 
    {
        public virtual void go()
        {  
        }
    }

    class Car : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The car is moving!");
        }
    }
    class Boat : Vehicle
    {
        public override void go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
