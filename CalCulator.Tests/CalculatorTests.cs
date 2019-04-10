using Calculator;
using NUnit.Framework;
using System;

namespace CalCulator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_ValuesBiggerThan0_ShouldReturn5()
        {
            var calc = new Calculator.Calculator();

            var result = calc.Add(2, 3);

            Assert.AreEqual(5, result);

        }

        [Test]
        public void Add_ValuesLessThan0_ShouldReturnMinus5()
        {
            var calc = new Calculator.Calculator();

            var result = calc.Add(-2, -3);

            Assert.AreEqual(-5, result);

        }
        [Test]
        public void Add_ValuesBiggerAndLowerThan0_ShouldReturnMinus1()
        {
            var calc = new Calculator.Calculator();

            var result = calc.Add(2, -3);

            Assert.AreEqual(-1, result);

        }
        [Test]
        public void Divide_ValuesBiggerThan0_ShouldReturn2()
        {
            var calc = new Calculator.Calculator();

            var result = calc.Divide(4, 2);

            Assert.AreEqual(2, result);

        }
        [Test]
        [TestCase(20,4,5)]
        [TestCase(40, 10, 4)]
        [TestCase(0, 10, 0)]
        public void Divide_PositiveValues_ShouldReturnEffect(double a, double b, double effect)
        {
            var calc = new Calculator.Calculator();

            var result = calc.Divide(a, b);

            Assert.AreEqual(effect, result);

        }
        [Test]
        public void Divide_DivideBy0_ShouldThrowException()
        {
            var calc = new Calculator.Calculator();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(6, 0));

        }

    }
}