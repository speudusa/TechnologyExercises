using TechnologyExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void TestIncreasingRam()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(2, testingComputer.Ram);
            testingComputer.IncreaseRam(3);
            Assert.AreEqual(5, testingComputer.Ram);

        }
    }
}
