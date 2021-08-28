using System;

namespace OOP_ArrayOfObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] garage = new Car[3];

            Car car1 = new Car("BMW");
            Car car2 = new Car("MARCEDES");
            Car car3 = new Car("TOYOTA");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;


            foreach (Car car in garage)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine(garage[0].model); 
        }
    }

    
    class Car
    {
        public String model;

        public Car(String model) {
            this.model = model;
        }
    }
}
