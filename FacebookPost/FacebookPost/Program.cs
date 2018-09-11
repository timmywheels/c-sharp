using System;
using System.Collections.Generic;
using System.Linq;

namespace FacebookPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var likes = new List<string>();
            var input = String.Empty;

            likes.ForEach(like => Console.WriteLine("{0}\t", like));

            do
            {
                Console.Write("Enter a name: ");
                input = Console.ReadLine();
                
                likes.Add(input);
                
            } while (!string.IsNullOrWhiteSpace(input));

            var likesCount = likes.Count();

            if (likesCount == 2)
            {
                Console.WriteLine("{0} likes your post", likes[0]);
            }
            else if (likesCount == 3)
            {
                Console.WriteLine("{0} and {1} like your post", likes[0], likes[1]);
            }
            
            else if (likesCount == 4)
            {
                Console.WriteLine("{0}, {1}, and {2} other friend like your post", likes[0], likes[1], (likesCount - 3));
            }
            
            else if (likesCount > 4)
            {
                Console.WriteLine("{0}, {1}, and {2} others like your post", likes[0], likes[1], (likesCount - 3));
            }
            
            else
            {
                Console.WriteLine("");
            }
        }
    }
}