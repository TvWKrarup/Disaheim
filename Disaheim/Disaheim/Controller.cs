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
        // Attributter
        private MerchandiseRepository merchandiseRepo;
        private CourseRepository courseRepo;

        // Operations
        // Constructor
        public Controller()
        {
            merchandiseRepo = new MerchandiseRepository();
            courseRepo = new CourseRepository();
        }
       
        // Methods
        public void AddToList(Merchandise merchandise)
        {
            merchandiseRepo.AddMerchandise(merchandise);
        }

        public void AddToList(Course course)
        {
            courseRepo.AddCourse(course);
        }   
    }
}
