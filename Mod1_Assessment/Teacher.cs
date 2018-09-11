using System;

namespace Mod1_Assessment
{
    public class Teacher
    {
            
        public string Name { get; set; }
        public string Subject { get; set; }

        // If teacher's name and subject are available
        public Teacher(string name, string subject)
        {
            this.Name = name;
            this.Subject = subject;

            teachers++;

        }

        // If only teacher's name is available
        public Teacher(string name)
        {
            this.Name = name;

            teachers++;
        }

        // Count number of teachers
        private static int teachers = 0;

        public Teacher()
        {
            teachers++;
        }

        public static int CountTeachers()
        {
            return teachers;
        }
    }
}