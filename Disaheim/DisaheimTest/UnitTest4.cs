using Disaheim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaheimTest
{
    [TestClass]
    public class UnitTest4
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;
        Course c1, c2;

        CourseRepository courses;
        MerchandiseRepository merchandises;

        [TestInitialize]
        public void Init()
        {
            // Arrange
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");

            c1 = new Course("Eufori med røg");
            c2 = new Course("Nuru Massage using Chia Oil", 157);

            courses = new CourseRepository();
            merchandises = new MerchandiseRepository();

            // Act
            merchandises.AddMerchandise(b1);
            merchandises.AddMerchandise(b2);
            merchandises.AddMerchandise(b3);

            merchandises.AddMerchandise(a1);
            merchandises.AddMerchandise(a2);
            merchandises.AddMerchandise(a3);

            courses.AddCourse(c1);
            courses.AddCourse(c2);
        }

        [TestMethod]
        public void TestGetBook()
        {
            // Assert
            Assert.AreEqual(b2, merchandises.GetMerchandise("2"));
        }
        [TestMethod]
        public void TestGetAmulet()
        {
            // Assert
            Assert.AreEqual(a3, merchandises.GetMerchandise("13"));
        }
        [TestMethod]
        public void TestGetCourse()
        {
            // Assert
            Assert.AreEqual(c1, courses.GetCourse("Eufori med røg"));
        }
        [TestMethod]
        public void TestGetTotalValueForBook()
        {
            // Assert
            Assert.AreEqual(183.55, merchandises.GetTotalValue());
        }
        [TestMethod]
        public void TestGetTotalValueForAmulet()
        {
            // Assert
            Assert.AreEqual(183.55, merchandises.GetTotalValue());
        }
        [TestMethod]
        public void TestGetTotalValueForCourse()
        {
            // Assert
            Assert.AreEqual(2625.0, courses.GetTotalValue());
        }
    }

}
