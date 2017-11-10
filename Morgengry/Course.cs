using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes;
        public double CourseHourValue;

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
        public double GetValue()
        {
            int noOfHours = DurationInMinutes / 60;

            if (DurationInMinutes % 60 > 0)
            {
                noOfHours++;
            }
            return 875 * noOfHours;
        }
    }
}
