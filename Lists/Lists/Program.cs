using System;
using System.Collections.Generic;
// MUST IMPORT GENERIC TYPES TO USE LISTS

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists are dynamic, whereas Arrays are static
            // Lists are a generic type

            // Example List

            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});

            foreach (var number in numbers)
                Console.WriteLine(number);

            // IndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));

            // LastIndexOf()
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            // Count
            Console.WriteLine("Count: " + numbers.Count);

            // Remove
            // foreach throws error, so use regular for loop
            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //        numbers.Remove(number);
            //}
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            // Clear()
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

            Console.WriteLine();
            // Useful List methods
            // Add()
            // AddRange()
            // Remove()
            // RemoveAll()
            // IndexOf()
            // Contains()
            // Count
        }
    }
}
