using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreTest.Controllers;

namespace CoreTest.Controllers.Tests
{
    [TestClass()]
    public class CalcControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Assign
            var test = new CalcController();
            // Act
            var result = test.Add(1, 2);
            // Assert
            Assert.AreEqual(5, result);
        }
    }
}