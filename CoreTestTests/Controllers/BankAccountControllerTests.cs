using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreTest.Controllers;
using NuGet.Frameworks;

namespace CoreTest.Controllers.Tests
{
    [TestClass()]
    public class BankAccountControllerTests
    {
        BankAccountController controller = new BankAccountController();
        [TestInitialize]
        public void Initialize()
        {
            // Initialize
            controller.Deposit(1000);
        }

        [TestMethod()]
        [DataRow(1000, 2000)]
        [DataRow(-1000, 1000)]
        [DataRow(-1, 1000)]
        [DataRow(10, 1010)]
        public void DepositTests(int amount, int expected)
        {
            // Arrange
            // Act
            if (amount < 0)
            {
                Assert.ThrowsException<ArgumentException>(() => controller.Deposit(amount));
            }
            else
            {
                controller.Deposit(amount);
            }
            //  Assert
            Assert.AreEqual(expected, controller.Balance);
        }

        [TestMethod()]
        [DataRow(1000, 0)]
        [DataRow(-1000, 1000)]
        [DataRow(-1, 1000)]
        [DataRow(10, 990)]
        public void WithdrawTests(int amount, int expected)
        {
            // Arrange
            // Act
            if (amount < 0)
            {
                Assert.ThrowsException<ArgumentException>(() => controller.Withdraw(amount));
            }
            else
            {
                controller.Withdraw(amount);
            }
            //  Assert
            Assert.AreEqual(expected, controller.Balance);
        }
    }
}