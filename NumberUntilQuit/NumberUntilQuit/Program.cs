using System;
using System.Collections.Generic;

namespace NumberUntilQuit
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = String.Empty;

            var numbers = new List<string>();
            
            do
            {
                
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (input == "quit")
                {
                    
                }
                
                else if (!numbers.Contains(input))
                {
                    numbers.Add(input);
                }
                
                
            } while (input != "quit");
            
            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.Write(number + " ");             
            }
        }
    }
}