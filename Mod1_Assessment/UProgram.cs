using System;

namespace Mod1_Assessment
{
    public class UProgram
    {
        public string ProgramName { get; set; }
        public Degree Degree { get; set; }

        public UProgram(string programName)
        {
            this.ProgramName = programName;
        }

        public UProgram()
        {
            
        }
    }
}
