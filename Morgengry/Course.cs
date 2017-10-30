using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : Merchandise
    {
        public string Name;
        public int DurationInMinutes;

        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes;
        }

        public Course(string inName)
        {
            Name = inName;
            DurationInMinutes = 0;
        }
        public Course(string inName, int inDurationinMinutes)
        {
            Name = inName;
            DurationInMinutes = inDurationinMinutes;
        }
    }
}
