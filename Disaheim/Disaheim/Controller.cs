using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        // Properties
        public List<Book> Books { get; set; }
        public List<Amulet> Amulets { get; set; }

        // Operations
        // Constructor
        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }


        // Methods
        // De to metoder hedder det samme, men er overloaded.
        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    }
}
