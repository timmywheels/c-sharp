using System;

namespace ReferenceTypes
{

    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Not aaffected by the Increment method
            var number = 1;

            // Only available in the scope of the Increment method
            // Not within Main
            Increment(number);

            // Returns 1, does not increment as it's out of scope
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };


            // This does increment the persons age as it's incrementing it's
            // Refernce -> see Person person
            MakeOld(person);
           
            // Outputs 30
            Console.WriteLine(person.Age);


        }

        public static void Increment(int number)
        {
            number += 10;
        }

        // Object here is a reference type (Person person)
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
