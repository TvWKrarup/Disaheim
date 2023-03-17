using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        // Pris bog return
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        // Værdi retur. Kan også laves som switch (amulet.Quality)  case Level.Low...etc.
        public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Level.low)
            {
                return 12.5;
            }
            if (amulet.Quality == Level.medium)
            {
                return 20.0;
            }
            if (amulet.Quality == Level.high)
            {
                return 27.5;
            }
            return 0;
        }

        // 875 pr. påbegyndt time
        public double GetValueOfCourse(Course course)
        {
            // Hvis 0 minutter koster det 0.
            if (course.DurationInMinutes == 0)
            {
                return 0;
            }
            
            // Hvis kursets længde har en remainder på 0 kan vi blot gange med prisen for hver påbegyndt time.
            if (course.DurationInMinutes % 60 == 0)
            {
                double courseValue = (course.DurationInMinutes / 60)*875;
                return courseValue;
            }

            // Hvis kursets længde ikke har en remainder på 0 skal vi blot tilføje 1 til vores påbegyndt time
            // og så kan vi igen gange med prisen og returnere. 
            int courseHours = (course.DurationInMinutes / 60)+1;
            double coursePrice = courseHours * 875;
            return coursePrice;            
        }

    }
}
