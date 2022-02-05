using System;
using CalculatorTryCatch;
using NUnit.Framework;

namespace CalculatorNUnitTest
{
    public class Tests
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(10,2,12)]
        [TestCase(20, -2, 18)]
        [TestCase(22, 22, 44)]
        public void TestOfAdding(double a, double b, double expected)
        {
            Assert.That(uut.Add(a,b), Is.EqualTo(expected));
        }

        [TestCase(10, 2, 8)]
        [TestCase(20, -2, 22)]
        [TestCase(22, 22, 0)]
        public void TestOfSubtracking(double a, double b, double expected)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(expected));
        }

        [TestCase(10, 2, 20)]
        [TestCase(20, -2, -40)]
        [TestCase(22, 3, 66)]
        public void TestOfMultiply(double a, double b, double expected)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(expected));
        }

        [TestCase(10, 2, 100)]
        [TestCase(5, 2, 25)]
        [TestCase(2, 4, 16)]
        public void TestOfPower(double a, double b, double expected)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(expected));
        }

        [TestCase(100, 2, 100)]
        [TestCase(5, 200, 25)]
        [TestCase(200, 4, 16)]
        public void ctor_NumbersToLarge(double a, double b, double exp)
        {
            Assert.That(() => uut.Add(a,b), Throws.TypeOf<Exception>().With.Message.EqualTo("Number to large"));
        }
        // dette skal s� i teorien g�res for alle metoderne
    }
}