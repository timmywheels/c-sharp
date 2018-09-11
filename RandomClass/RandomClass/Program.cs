using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];

            for (var i = 0; i < 10; i++)
            {
                //Console.WriteLine(random.Next(1, 10)); // Outputs nums between 1-10
                //Console.Write((char)random.Next(97, 122)); // Type-cast each number to ascii letter

                buffer[i] = (char)('a' + random.Next(0, 26));

                var password = new string(buffer);
                
                Console.WriteLine(password);

            
            }

            Console.WriteLine((int)'a'); // Outputs 97



        }
    }
}
