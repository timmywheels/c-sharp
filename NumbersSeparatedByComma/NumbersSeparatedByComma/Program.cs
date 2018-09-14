using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersSeparatedByComma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a series of numbers separated by a comma: ");
            var input = Console.ReadLine();

            List<string> numbers = input.Split(',').ToList<string>();

            var highestNumber = 0;
            
            foreach (var number in numbers)
            {
                
                if (Convert.ToInt32(number) > highestNumber)
                {
                    highestNumber = Convert.ToInt32(number);
                }
                
                
            }

            Console.WriteLine("Highest Number: {0}", highestNumber);
        }
    }
}