using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgengry;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        Book b1, b2, b3;
        Amulet a11, a12, a13;
        Course c111, c112;
        //MerchandiseRepository merchandises = new MerchandiseRepository();
        CourseRepository courses = new CourseRepository();

        [TestInitialize]
        public void Init()
        {
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);
            //merchandises.AddMerchandise(b1);
           // merchandises.AddMerchandise(b2);
           // merchandises.AddMerchandise(b3);

            a11 = new Amulet("11");
            a12 = new Amulet("12", Level.high);
            a13 = new Amulet("13", Level.low, "Capricorn");
           // merchandises.AddMerchandise(a11);
           // merchandises.AddMerchandise(a12);
           // merchandises.AddMerchandise(a13);

            c111 = new Course("Eufori med røg");
            c112 = new Course("Nuru Massage using Chia Oil", 157);
            courses.AddCourse(c111);
            courses.AddCourse(c112);
        }
        //[TestMethod]
        //public void TestGetValueForBook()
        //{
        //    Assert.AreEqual(Utility.GetValueOfMerchandise(b1), 0.0);
        //    Assert.AreEqual(Utility.GetValueOfMerchandise(b2), 0.0);
        //    Assert.AreEqual(Utility.GetValueOfMerchandise(b3), 123.55);
        //    Assert.AreEqual(merchandises.GetTotalValue(), 123.55);
        //}

        //[TestMethod]
        //public void TestGetValueForAmulet()
        //{
        //    Assert.AreEqual(Utility.GetValueOfMerchandise(a11), 20.0);
        //    Assert.AreEqual(Utility.GetValueOfMerchandise(a12), 27.5);
        //    Assert.AreEqual(Utility.GetValueOfMerchandise(a13), 12.5);
        //    Assert.AreEqual(merchandises.GetTotalValue(), 60.0);
        //}

        [TestMethod]
        public void TestGetValueForCourse()
        {
            Assert.AreEqual(c111.GetValue(), 0.0);
            Assert.AreEqual(c112.GetValue(), 2625.0);
            Assert.AreEqual(courses.GetTotalValue(), 2625.0);
        }


    }

}
