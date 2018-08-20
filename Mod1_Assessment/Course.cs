using System;

namespace Mod1_Assessment
{
    public class Course
    {

        public string CourseName { get; set; }
        public Teacher Teacher { get; set; }
        
        public Course(string courseName)
        {
            this.CourseName = courseName;
        }
    }
}
