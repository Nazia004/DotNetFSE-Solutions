using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [Test]
        public void Addition_TwoNumbers_ReturnsSum()
        {
            Assert.That(calculator.Addition(10, 5), Is.EqualTo(15));
        }

        [Test]
        public void Subtraction_TwoNumbers_ReturnsDifference()
        {
            Assert.That(calculator.Subtraction(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void Multiplication_TwoNumbers_ReturnsProduct()
        {
            Assert.That(calculator.Multiplication(10, 5), Is.EqualTo(50));
        }

        [Test]
        public void Division_TwoNumbers_ReturnsQuotient()
        {
            Assert.That(calculator.Division(10, 5), Is.EqualTo(2));
        }

        [Test]
        public void Division_ByZero_ThrowsArgumentException()
        {
            Assert.That(() => calculator.Division(10, 0),
                Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void AllClear_ResetsResultToZero()
        {
            calculator.Addition(20, 30);
            calculator.AllClear();

            Assert.That(calculator.GetResult, Is.EqualTo(0));
        }

        [Test]
        public void GetResult_ReturnsLastCalculatedValue()
        {
            calculator.Multiplication(7, 6);

            Assert.That(calculator.GetResult, Is.EqualTo(42));
        }

        [TestCase(2, 3, 5)]
        [TestCase(10, 20, 30)]
        [TestCase(-5, 5, 0)]
        public void Addition_Parameterized(double a, double b, double expected)
        {
            Assert.That(calculator.Addition(a, b), Is.EqualTo(expected));
        }
    }
}