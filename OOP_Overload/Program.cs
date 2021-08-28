using System;

namespace OOP_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Overloading Constructor

            Pizza pizza = new Pizza("Cracker Crust");
            Pizza pizza2 = new Pizza("Cracker Crust" , "red sauce");
            Pizza pizza3 = new Pizza("stuffeld Crust" , "white sauce" , "cheese");
        }
    }
}
