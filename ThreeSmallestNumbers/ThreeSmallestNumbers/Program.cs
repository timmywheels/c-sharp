using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeSmallestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (count != 5)
            {
                Console.Write("Enter 5 numbers, separated by commas: ");
                var input = Console.ReadLine();
                
                var split = input?.Split(',');
                var numbers = split.ToList();
                
                foreach (var number in numbers)
                {
                    count++;
                }
                
                if (count == 5)
                {
                    numbers.Sort();
                    Console.WriteLine("Lowest three numbers: {0}, {1}, {2}", numbers[0], numbers[1], numbers[2]);
                }
                else
                {
                    count = 0; // Reset count to zero
                    Console.WriteLine("Invalid List");
                }
            }
        }
    }
}