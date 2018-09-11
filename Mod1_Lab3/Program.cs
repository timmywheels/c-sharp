using System;

namespace Mod1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();

            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            var Car2 = new Car("Red", 2018);

            var Car3 = new Car(2018, 20000);

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine($"There are {carCount} cars in stock right now.");
        }
    }
}