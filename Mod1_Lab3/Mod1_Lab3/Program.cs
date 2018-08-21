using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var anAnonymousObject = new { Name = "Tom", Age = 65 };

            Console.WriteLine("Name: {0} Age: {1}", anAnonymousObject.Name, anAnonymousObject.Age};

    }
}
}
