using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sparky;

namespace sparky
{
    [TestFixture]
    class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //arrange
            Calculator calc = new();

            //act
            int result = calc.AddNumbers(10, 20);

            //assert
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(5.4, 10.5)]
        [TestCase(5.43, 10.53)]
        [TestCase(5.49, 10.59)]
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //arrange
            Calculator calc = new();

            //act
            double result = calc.AddNumbersDouble(a, b);

            //assert
            Assert.AreEqual(15.9, result, .2);
        }

        [Test]
        public void IsOddChecker_InputOddNumber_ReturnTrue()
        {

            Calculator calc = new();
            bool isOdd = calc.IsOddNumber(11);

            Assert.That(isOdd, Is.EqualTo(true));
            // Assert.IsFalse(11);
        }
        [Test]
        public void IsOddChecker_InputOddNumber_ReturnFalse()
        {

            Calculator calc = new();
            bool isOdd = calc.IsOddNumber(11);

            Assert.That(isOdd, Is.EqualTo(true));
            // Assert.IsFalse(11);
        }

        //
        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {

            Calculator calc = new();
            bool isOdd = calc.IsOddNumber(a);

            Assert.That(isOdd, Is.EqualTo(true));
            // Assert.IsFalse(11);
        }

        [Test]
        [TestCase(10, ExpectedResult =false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calc = new();
            return calc.IsOddNumber(a);
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            //arrange
            Calculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 };
            //act
            List<int> result = calc.GetOddRange(5, 10);
            //Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            // Assert.AreEqual( expectedOddRange, result);
            //Assert.Contains(7, result);
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

        }

    }
}
