using System;

namespace oop_2___CreateObject
{
    public class Person
    {
        #region Variables
        public String name;
        public int age;
        public String job;
        public int experience;
        public static int personNum;
        #endregion

        // constructor
        public Person(String personname , int age , String job , int experience) {
            this.name = personname;
            this.age = age;
            this.job = job;
            this.experience = experience;
            personNum++;
        }



         /// <summary>
        /// Print the person information.
        /// </summary>
        public void ShowData() {
        Console.WriteLine("************************");
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Age: " + this.age);
        Console.WriteLine("Job: " + this.job);
        Console.WriteLine(this.experience + " Years Experience");
        Console.WriteLine("************************");
        }

        public static void NumOfPerson() {
            Console.WriteLine("Number Of Person Is: " + personNum);
        }
    }
}