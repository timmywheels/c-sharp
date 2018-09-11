using System;

namespace Birthdate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1991, 04, 05));
//            person.SetBirthdate(new DateTime(1991, 04, 05));
//            Console.WriteLine(person.GetBirthDate());
            Console.WriteLine(person.Age);
        }
    }
}