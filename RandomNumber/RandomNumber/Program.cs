using System;
using System.Reflection.Metadata.Ecma335;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new Random().Next(0,11);
            Console.WriteLine("Secret Number: {0}", num);

            var guessCount = 0;
            
            Console.Write("Guess a number between 1 and 10: ");
            var guess = Convert.ToInt32(Console.ReadLine());
            ++guessCount;
            
            if (guessCount < 3)
            {
                Console.WriteLine("You have {0} guesses left!", (4 - guessCount));
            }
            else if (guessCount == 3)
            {
                Console.WriteLine("You have {0} guess left!", (4 - guessCount));
            }


            while (guess != num && guessCount < 4)
            {
                Console.Write("Guess a number between 1 and 10: ");
                guess = Convert.ToInt32(Console.ReadLine());
                ++guessCount;
                
                if (guessCount < 3)
                {
                    Console.WriteLine("You have {0} guesses left!", (4 - guessCount));
                }
                else if (guessCount == 3)
                {
                    Console.WriteLine("You have {0} guess left!", (4 - guessCount));
                }
            }

            if (guess == num)
            {
                Console.WriteLine("Great job! You guessed it in {0} guesses!", guessCount);
                return;
            }
            
            if (guessCount >= 4)
            {
                Console.WriteLine("You ran out of guesses! Try again.");
                
            }

        }
    }
}