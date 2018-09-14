using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveUniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var uniqueNums = new List<string>();

            var count = 1;

            while (count < 6)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                
                if (uniqueNums.Contains(input))
                {
                    Console.Write("Enter a unique number: ");
                    input = Console.ReadLine();
                }
                else
                {
                    uniqueNums.Add(input);
                    input = String.Empty;
                    count++;
                }
            }
            
            uniqueNums.Sort();

            foreach (var num in uniqueNums)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}