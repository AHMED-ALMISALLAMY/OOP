using System;

namespace OOP__Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();
        }
    }

    class Vehicle
    {
        public int speed = 0;
        
        public void go() {
             Console.WriteLine("This Vehicle is moving!");
        }
    }

    class Car : Vehicle 
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 100;
    }
}
