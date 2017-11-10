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
        public double CourseHourValue { get; set; } = 875.00;

        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;
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
            int retsminutter = DurationInMinutes - (noOfHours * 60);
            if (retsminutter > 0)
            {
                noOfHours++;
            }
            return CourseHourValue * noOfHours;
        }
    }
}
