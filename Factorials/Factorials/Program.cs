using System;

namespace Factorials
{
    class Factor
    {
        public int Factorialize(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            
            return num * Factorialize(num - 1);
            
        }
        
    }
    
    class Program
    {
        private static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var sum = new Factor().Factorialize(input);

            Console.Write(input + "! = ");
            Console.WriteLine((int)sum);
        }
    }
}
