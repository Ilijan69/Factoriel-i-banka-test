using NUnit.Framework;
using FactorialTest; // Reference to your main project namespace

namespace FactorialTest.Tests
{
    public class ExtendedCalculatorShould
    {
        [Test]
        public void CalculateCorrectFactorial()
        {
            // Arrange
            var calculator = new ExtendedCalculator();

            // Act
            var result = calculator.Factorial(3);

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }
    }
}