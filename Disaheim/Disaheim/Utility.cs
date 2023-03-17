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
    }
}
