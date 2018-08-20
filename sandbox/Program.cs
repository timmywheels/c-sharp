using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonObj = new { Name = "Tom", Age = 65 };
            
            Console.WriteLine("Name: {0} Age: {1}", anonObj.Name, anonObj.Age);
            
            // anonObj.Name = "Tim";
            
            
        }
    }
}

