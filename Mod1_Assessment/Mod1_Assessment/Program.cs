using System;

namespace Mod1_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate UProgram
            var Program1 = new UProgram("Information Technology");

            // Instantiate students
            var Student1 = new Student("Tim", "Computer Science");
            var Student2 = new Student("Andrea", "Data Science");
            var Student3 = new Student("Lisa", "Information Technology");

            // Instantiate teachers
            var Teacher1 = new Teacher("Mr. Wheeler", "Computer Science");

            // Instantiate Degree
            var Degree1 = new Degree("Masters");

            // Instantiate Course
            var Course1 = new Course("Intro to Computer Science 101");

            // Access StudentCount
            int countStudents = Student.CountStudents();

            Console.WriteLine($"This program is {Program1.ProgramName} and upon completion you will receive a {Degree1.DegreeType} degree.");
            Console.WriteLine($"The course is {Course1.CourseName}");
            Console.WriteLine($"There are currently {countStudents} students enrolled.");
            Console.WriteLine($"{Teacher1.Name} is the teacher.");
        }
    }
}
