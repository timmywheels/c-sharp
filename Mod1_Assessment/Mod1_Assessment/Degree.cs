using System;

namespace Mod1_Assessment
{
    public class Degree
    {
        public string DegreeType { get; set; }
        public Course Course { get; set; }

        public Degree(string degreeType)
        {
            this.DegreeType = degreeType;
        }

        public Degree()
        {
            
        }
    }
}
