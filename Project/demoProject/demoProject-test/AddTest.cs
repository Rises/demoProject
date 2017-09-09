using Microsoft.VisualStudio.TestTools.UnitTesting;
using demoProject;
using demoProject.Add;
using demoProject.Subtract;

namespace demoProject_test
{
    [TestClass]
    public class AddTest
    {
        int a = 20;
        int b = 10;
        int add = 30;

        [TestMethod]
        public void TestAddIntegers()
        {
            AddIntegers obj = new AddIntegers();
            int actualSum = obj.AddNumbers(a, b);
            Assert.AreEqual(actualSum, add, 0.001, "Good!");
        }
    }
}
