using TechnologyExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void TestInheritsId()
        {
            //is the id being updated??
            Computer test_computer = new Computer(2, 3, true);
            Assert.AreEqual(1, test_computer.Id);

            Computer test_computer2 = new Computer(4, 6, true);
            Assert.AreEqual(2, test_computer2.Id);
        }

        [TestMethod]
        public void TestIncreasingRam()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(2, testingComputer.Ram);

            testingComputer.IncreaseRam(3);
            Assert.AreEqual(5, testingComputer.Ram);

        }

        [TestMethod]
        public void TestIncreasingStorage()
        {
            Computer testingComputer = new Computer(2, 3, true);
            Assert.AreEqual(3, testingComputer.Storage);

            testingComputer.IncreaseStorage(5);
            Assert.AreEqual(8, testingComputer.Storage);
        }
    }

}