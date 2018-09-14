using System;

namespace _Inheritance
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            Console.WriteLine("Logic changed");
        }

        public int CalculateRating()
        {
            return 0;
        }
        
    }
}