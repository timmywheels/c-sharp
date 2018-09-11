using System;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the vehicle speed: ");
            var speed = Convert.ToInt32(Console.ReadLine());

            var speedOver = speed - speedLimit;
            
            
            
            var demerits = Convert.ToInt32(speedOver / 5);
            
            if (speed <= speedLimit && speed > speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (speedOver > 0 && (demerits > 2))
            {
                Console.Write("Slow down! You have received ");
                Console.Write(demerits);
                Console.Write(" demerits!");
            }
        }
    }
}