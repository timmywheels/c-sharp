using System;
using NUnit.Framework;

namespace CalculatorApplication
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddNumbersTest()
        {
            var sut = new Calculator();

            var result = Calculator.AddNumbers(5, 10);
            
            Assert.That(result, Is.EqualTo(15));

        }

        [Test]
        public void SubtractNumbersTest()
        {
            var sut = new Calculator();

            var result = Calculator.SubtractNumbers(10, 5);
            
            Assert.That(result, Is.EqualTo(5));
        }
        
        
    }

    public class Calculator
    {
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static int SubtractNumbers(int a, int b)
        {
            return a - b;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorTests();
            
            calc.AddNumbersTest();
            calc.SubtractNumbersTest();
        }
    }
}