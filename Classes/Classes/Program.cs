using System;

namespace Classes
{

    class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
//            var person = new Person();
            var p = Person.Parse("Tim");
            p.Introduce("Andrea");
            
//            person.Name = "Tim";
//            
//            person.Introduce("Andrea");
        }
    }
}
