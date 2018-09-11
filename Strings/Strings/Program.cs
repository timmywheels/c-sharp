using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Tim";
            var lastName = "Wheeler";

            // Concatenating strings
            var fullName = firstName + " " + lastName;

            // String templates
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Tim", "Andrea", "Julie" };

            // Join strings at a separator
            var formattedNames = string.Join(",", names);

            Console.Write(formattedNames);

            // Verbatim strings using the '@' symbol
            var text = @"Hi Tim, please find the document in the c:/folder1/folder2 path.";

            Console.WriteLine(text);
        }
    }
}
