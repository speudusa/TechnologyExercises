using System;
using TechnologyExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTests
{
    [TestClass]
    public class LaptopTests
    {

        [TestMethod]
        public void TestingBaseClassInheritance()
        {
            //testing if methods have been inherited correctly
            Laptop testingLaptop = new Laptop(3, 5, false, 4.6);
            Assert.IsNotNull(testingLaptop.Id);
            Assert.AreEqual(false, testingLaptop.hasKeyboard);
            Assert.AreEqual(3, testingLaptop.Ram);
            Assert.AreEqual(7, testingLaptop.IncreaseRam(4));
            Assert.AreEqual(8, testingLaptop.IncreaseStorage(3));
        }

        [TestMethod]
        public void ClunkyTest()
        {
            //testing Laptop method
            Laptop testingLaptop1 = new Laptop(3, 5, false, 4.6);
            Assert.IsTrue(testingLaptop1.IsClunky());
            testingLaptop1.Weight = 5.6;
            Assert.IsFalse(testingLaptop1.IsClunky());
        }


    }
}
