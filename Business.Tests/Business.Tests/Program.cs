using System;
using NUnit.Framework;


namespace Business.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumbers_Valid_ExpectedResult()
        {
            var sut = new Calculator();
            var result = Calculator.AddNumbers(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }
    }

    public class Calculator
    {
        public static int AddNumbers(int a, int b)
        {
            return 0;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorTests();
            calc.AddNumbers_Valid_ExpectedResult();
        }
    }
    
}