using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Tim Wheeler ";

            // Removes whitespace
            Console.WriteLine("Trim: '{0}'", fullName.Trim());


            // Removes whitespace and converts to uppercase
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);


            Console.WriteLine(fullName.Replace("Tim", "Timothy"));

            // older
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");

            // newer
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            

            Console.WriteLine(age);


            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
           




        }
    }
}
