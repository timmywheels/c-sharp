using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();
            
            var reverse = new string(input.Reverse().ToArray());

            Console.WriteLine("Reverse: {0}", reverse);

        }
    }
}