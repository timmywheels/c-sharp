using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
	    var Audi = new Car
            {
                Color = "White",
                Model = "Audi",
                Year = 2010,
                Mileage = 11000
            };

            Console.WriteLine($"This is a {Audi.Model}, it was built in {Audi.Year} and the color is" +
                              $" {Audi.Color} and it currently has {Audi.Mileage} miles on it.");

        }
    }

    public class Car
    {
        public string Color { get; set; }
	public string Model { get; set; }
        public int Year { get; set;  }
        public int Mileage { get; set; }
	    
    }
}
