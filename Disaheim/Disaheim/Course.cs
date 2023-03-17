using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        // Properties
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

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
            return $"Name: {this.Name}, Duration in Minutes: {this.DurationInMinutes}";
        }


    }
}
