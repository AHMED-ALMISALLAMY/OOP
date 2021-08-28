using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> food = new List<String>();
            food.Add("pizza");
            food.Add("Hamurger");
            food.Add("Hotdog");

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
        }
    }
}
