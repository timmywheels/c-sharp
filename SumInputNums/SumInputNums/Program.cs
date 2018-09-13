using System;
using System.Collections.Generic;
using System.Linq;

namespace SumInputNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            
            var input = String.Empty;

            var total = 0;
            
            do
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
                Console.WriteLine("Enter another number | Enter 'ok' to exit");

                if (input != "ok")
                {
                    list.Add(input);
                }
                
            } while (input != "ok");



            foreach (var num in list.Select(int.Parse).ToList())
            {
                total += num;
            }

            Console.WriteLine(total);
            
        }
    }
}