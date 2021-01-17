using System;
using TestClassLib;
using Xunit;


namespace TestClassLibTesting
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAddsFiveAndFive()
        {
            double a = 5;
            double b = 5;
            double expected = 10;
            var calc = new Calculator();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAddsFiftyAndSeventy()
        {
            double a = 50;
            double b = 70;
            double expected = 120;
            var calc = new Calculator();

            double actual = calc.Add(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
