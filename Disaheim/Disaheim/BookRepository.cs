using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        // Attributes
        private List<Book> _books;
        
        // Methods

        // Tilføjer en bog til vores liste "_books".
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        // Hvis bogen eksisterer med et itemId returneres itemId (er lidt i tvivl om det er itemid eller selve bog der skal returneres
        // for nuværende.
        public Book GetBook(string itemId)
        {
            foreach (Book book in _books)
            {
                if (book.ItemId == itemId) 
                return book;
            }
            return null;
        }

        

        // Alle bøgers værdi samles i "total" og returneres når metoden kaldes.
        public double GetTotalValue()
        {
            double total = 0;
            foreach (Book book in _books)
            {  
                total += book.Price;
            }
            return total;
        }
    }
}
