using System;

namespace NumsDivisible100
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 100;

            var count = 0;

            for (var i = 1; i <= num; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.Write("Count: ");
            Console.Write(count);
        }
    }
}