using System;

namespace Mod1_Assessment
{
    public class Student
    {

        public string Name { get; set; }
        public string Major { get; set; }

        // If student's name and major are available
        public Student(string name, string major)
        {
            this.Name = name;
            this.Major = major;

            students++;

        }

        // If only student's name is available
        public Student(string name)
        {
            this.Name = name;

            students++;
        }

        // Count number of students
        private static int students = 0;

        public Student()
        {
            students++;
        }

        public static int CountStudents()
        {
            return students;
        }
    }
}
