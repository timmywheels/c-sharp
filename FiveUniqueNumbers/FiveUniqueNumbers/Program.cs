using System;
using System.Collections.Generic;

namespace FiveUniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var uniqueNums = new List<string>();

            var count = 0;

            while (count <= 5)
            {
                
                Console.Write("Enter a number: ");
                var input = Console.Read();
                
                if (!uniqueNums.Contains(input.ToString()))
                {
                    uniqueNums.Add(input.ToString());
                    ++count;
                }
                else
                {
                    Console.WriteLine("Enter a unique number!");
                }
            }
        }
    }
}