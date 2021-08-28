﻿using System;

namespace OOP_ObjectAsArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW" , "blue"); 
            Car car2 = Copy(car1);

            ChangeColor(car1 , "white");
            Console.WriteLine(car1.color + " " + car1.model);

            Console.WriteLine(car2.color + " " + car2.model);

        }

        public static void ChangeColor(Car car , String color) 
        {
            car.color = color;
        }

        public static Car Copy(Car car) 
        { 
            return new Car(car.model , car.color); 
        }
    }

    class Car 
    {
        public String model;
        public String color;

        public Car (String model , String color) 
        {
            this.model = model;
            this.color = color;
        }
    }
}
