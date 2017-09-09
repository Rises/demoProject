using Microsoft.VisualStudio.TestTools.UnitTesting;
using demoProject;
using demoProject.Add;
using demoProject.Subtract;

namespace demoProject_test
{
    [TestClass]
    public class SubtractTest
    {
        int a = 30;
        int b = 10;
        int sub = 20;

        [TestMethod]
        public void TestSubtractIntegers()
        {
            SubtractIntegers obj = new SubtractIntegers();
            int actualDiff = obj.SubtractNumbers(a, b);
            Assert.AreEqual(actualDiff, sub, 0.001, "Good!");
        }
    }
}
