using System;
using System.IO;

namespace Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\c-sharp\HelloWorld.sln";

            // Bad way
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            // Good way
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("Extension: " + Path.GetExtension(path));

            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension);
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
