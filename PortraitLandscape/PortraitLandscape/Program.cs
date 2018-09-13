using System;

namespace PortraitLandscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter image width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }
        }
    }
}