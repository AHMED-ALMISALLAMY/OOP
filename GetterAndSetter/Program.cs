using System;

namespace GetterAndSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapulation
            Car car = new Car(400);

            car.Speed = 100000000;
        }
    }

    class Car
    {
        private int speed;

        public Car(int speed) 
        {
            this.Speed = speed;
        }

        public int Speed {
            get {return speed;}   
            set 
            {
                if (value > 500)
                    speed = 500;
                else
                    speed = value;
            }
        } 
    }
}
