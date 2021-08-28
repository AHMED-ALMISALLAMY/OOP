using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum

            Console.WriteLine(Plants.Jupitar + " Is planet #" + (int)Plants.Jupitar);
        }
    }

    enum Plants
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3, 
        Mars = 4, 
        Jupitar = 5, 
        Saturn = 6, 
        Uranus = 7, 
        Neptune = 8, 
        Pluto = 8,
    }
}
