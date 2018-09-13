using System;

namespace NumBetween1and10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10:");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input > 10 || input < 1)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

        }
    }
}