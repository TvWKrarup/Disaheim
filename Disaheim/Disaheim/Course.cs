using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        // Properties
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        private static double _courseHourValue = 875;
        public static double CourseHourValue 
        { 
            get { return _courseHourValue; }
            set { _courseHourValue = value; } 
        }

        // Operations
        // Constructor
        public Course(string name) 
        { 
            this.Name = name;
        }
        // Chained constructor
        public Course(string name, int durationInMinutes) :
            this(name)
        { 
            this.DurationInMinutes = durationInMinutes;
        }

        // Methods
        public override string ToString()
        {
            return $"Name: {this.Name}, Duration in Minutes: {this.DurationInMinutes}, Value: {GetValue()}";
        }

        // Implementation af IValuable interface
        public double GetValue()
        {
            if (this.DurationInMinutes == 0)
            {
                return 0;
            }

            // Hvis kursets længde har en remainder på 0 kan vi blot gange med prisen for hver påbegyndt time.
            if (this.DurationInMinutes % 60 == 0)
            {
                double courseValue = (this.DurationInMinutes / 60) * CourseHourValue;
                return courseValue;
            }

            // Hvis kursets længde ikke har en remainder på 0 skal vi blot tilføje 1 til vores påbegyndt time
            // og så kan vi igen gange med prisen og returnere. 
            int courseHours = (this.DurationInMinutes / 60) + 1;
            double coursePrice = courseHours * CourseHourValue;
            return coursePrice;
        }
    } 
}
