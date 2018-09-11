using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            // Length
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("The Effect of Clear()");
            // Clears the first 2 items in array and sets to 0
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
                 Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);


            //// Declare an array of 5 items
            //var numbers = new int[5];

            //// Declare an array of 5 items, and add the items
            //var numbers = new int[5] { 1, 2, 3, 4, 5 };

            //// MULTIDIMENSIONAL ARRAYS - 2 types

            //// Rectangular Arrays
            //// Syntax: Declared with 1 array separated with comma
            //var matrix = new int[3, 5]
            //{
            //    {1,2,3,4,5},
            //    {6,7,8,9,10},
            //    {11,12,13,14,15}
            //};

            //// Jagged Arrays
            //// Syntax: Declared with 2 arrays
            //var array = new int[3][];

            //// Must declare each array
            //array[0] = new int[4];
            //array[1] = new int[5];
            //array[2] = new int[3];

            //// Accessing jagged array
            //array[0][0] = 1;

        }
    }
}
