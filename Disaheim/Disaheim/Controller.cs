using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        // Properties

        private readonly BookRepository _bookRepo; 
        private readonly AmuletRepository _amuletRepo;
        private readonly CourseRepository _courseRepo;

        // Operations
        // Constructor
        public Controller()
        {
            _bookRepo = new BookRepository();
            _amuletRepo = new AmuletRepository();
            _courseRepo = new CourseRepository();
        }
        
       
        // Methods
        // De tre metoder hedder det samme, men er overloaded.
        public static void AddToList(Book book)
        {  
            BookRepository bookRepository = new BookRepository();
            bookRepository.AddBook(book);
        }

        public void AddToList(Amulet amulet)
        {
            _amuletRepo.AddAmulet(amulet);
        }

        public void AddToList(Course course)
        {
            _courseRepo.AddCourse(course);
        }
       



    }
}
