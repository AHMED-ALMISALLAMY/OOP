using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // You Can Add Generic To (classes , methods , field ,  etc)

            int[] intArray = {1,2,3,4};
            double[] doubleArray = {1.0,2.0,3.0,4.0};
            String[] stringArray = {"1","2","3","4"};

            displayElement(intArray);
            displayElement(doubleArray);
            displayElement(stringArray);
        }

        public static void displayElement<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item + " ");
            }
        }

        // public static void displayElement(double[] array)
        // {
        //     foreach (double item in array)
        //     {
        //         Console.WriteLine(item + " ");
        //     }
        // }

        // public static void displayElement(String[] array)
        // {
        //     foreach (String item in array)
        //     {
        //         Console.WriteLine(item + " ");
        //     }
        // }
    }
}
