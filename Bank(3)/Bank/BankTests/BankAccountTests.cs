using Bank;
using NUnit.Framework;
using System;

namespace BankTests
{
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount("Test User", 100.00);  // Initialize with a balance of 100
        }

        [Test]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double amount = 30.00;
            double expectedBalance = 70.00;

            // Act
            account.Debit(amount);

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [Test]
        [TestCase(-3)]
        [TestCase(150)]
        public void Debit_ShouldThrowException_WhenInvalidAmount(double amount)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Debit(amount));
        }

        [Test]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double amount = 50.00;
            double expectedBalance = 150.00;

            // Act
            account.Credit(amount);

            // Assert
            Assert.AreEqual(expectedBalance, account.Balance);
        }

        [Test]
        public void Credit_ShouldThrowException_WhenNegativeAmount()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Credit(-10));
        }
    }
}
