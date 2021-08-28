using System;

namespace oop_2___CreateObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object named person1 from Person class.
            Person person1 = new Person("Ahmed" , 15 , "programmer" , 2);
            person1.ShowData();


            // create object named person2 from Person class.
            Person person2 = new Person("Mohammed" , 17 , "engineer" , 4);
            person2.ShowData();


            // Console.WriteLine("Numbers Of Person Is " + Person.personNum);

            Person.NumOfPerson();
            
        }
    }
}
