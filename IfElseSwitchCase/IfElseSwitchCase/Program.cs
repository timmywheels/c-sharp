using System;

namespace IfElseSwitchCase
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var season = Seasons.Autumn;

            switch (season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("It's football season");
                    break;
                case Seasons.Summer:
                    Console.WriteLine("It's beach season");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("It's winterhat season");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("It's the awesome season");
                    break;
                default:
                    Console.WriteLine("Please enter a valide season.");
                    break;
            }

            //bool isGoldCustomer = false;
            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //price = 29.95;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);



            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It's morning.");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("It's afternoon");
            //else
                //Console.WriteLine("It's evening.");

        }
    }
}
