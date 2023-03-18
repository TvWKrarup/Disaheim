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

        private BookRepository _bookRepo;
        private AmuletRepository _amuletRepo;
        private CourseRepository _courseRepo;

        // Operations
        // Constructor
        public Controller()
        {
            _bookRepo = new List<Book>();
            _amulets = new List<Amulet>();
            _courses = new List<Course>();
        }
        

        // Methods
        // De tre metoder hedder det samme, men er overloaded.
        public void AddToList(Book book)
        {
            _books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            _amulets.Add(amulet);
        }

        public void AddToList(Course course)
        {
            _courses.Add(course);
        }




    }
}
