using System;
using Xunit;
using Calculators;

namespace CalculatorTests
{
    public class CTests
    {
        private Calculator calculator = new Calculator();

        [Theory]
        [InlineData(1, 2, 3)]
        public void AddTest(int firstVal, int secondVal, int expectedResult)
        {
            var result = calculator.Add(firstVal, secondVal);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void SubTest(int firstVal, int secondVal, int expectedResult)
        {
            var result = calculator.Sub(firstVal, secondVal);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        public void MulTest(int firstVal, int secondVal, int expectedResult)
        {
            var result = calculator.Mul(firstVal, secondVal);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        public void DivTest(int firstVal, int secondVal, int expectedResult)
        {
            var result = calculator.Div(firstVal, secondVal);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, 5)]
        public void FibTest(int value, int expectedResult)
        {
            var result = calculator.Fib(value);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, true)]
        public void PrimeTest(int value, bool expectedResult)
        {
            var result = calculator.Prime(value);

            Assert.Equal(expectedResult, result);
        }

        /*
        public void BalTest()
        {

        }
        */
    }
}
