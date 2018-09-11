using System;

namespace DisplayHigherNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var inputOne = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter another number: ");
            var inputTwo = Convert.ToInt32(Console.ReadLine());

            if (inputOne > inputTwo)
            {
                Console.WriteLine(inputOne);
            }
            else
            {
                Console.WriteLine(inputTwo);
            }
            
        }
    }
}