using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            // FOR LOOPS
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //for (var i = 10; i >= 1; i--)
            //{

            //    if (i % 2 == 0)
            //        Console.WriteLine(i);

            //}


            // FOR EACH LOOPS
            //var name = "Tim Wheeler";

            //foreach (var letter in name)
            //Console.WriteLine(letter);

            // WHILE LOOPS
            //var i = 0;

            //while (i <= 25)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);

            //    i++;
            //}

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;


            }


        }
    }
}
