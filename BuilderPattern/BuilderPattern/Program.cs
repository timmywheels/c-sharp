using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new PersonBuilder().Build();
            
            var person2 = new PersonBuilder().WithAge(32).Build();

            var person3 = new PersonBuilder().WithFirstName("Andrea").WithLastName("Beland").WithAge(24).Build();

            Console.WriteLine(person3);
        }
    }
}
