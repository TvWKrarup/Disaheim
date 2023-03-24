using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        // Attributter
        private List<IValuable> valuables = new List<IValuable>();


        // Methods
        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);   
        }

        // Få fat i specifik valuable som matcher et itemId eller Name (Courses)
        public IValuable GetValuable(string itemId)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Course course)
                {
                    if (course.Name == itemId)
                        return course;
                }
                else if (valuable is Book book)
                {
                    if (book.ItemId == itemId)
                        return book;
                }
                else if (valuable is Amulet amulet)
                {
                    if (amulet.ItemId == itemId)
                        return amulet;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (IValuable valuable in valuables)
            {
                total += valuable.GetValue();
            }
            return total;
        }

        public int Count()
        {
            int count = 0;

            foreach (IValuable valuable in valuables) 
            { 
                count++; 
            }
            return count;
        }



    }
}
