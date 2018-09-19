using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CalculatorApp
{

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddTest()
        {
            var sut = new Calculator();

            var result = Calculator.Add(10, 2);
            
            Assert.That(result, Is.EqualTo(12));
            
        }

        [Test]
        public void SubtractTest()
        {
            var sut = new Calculator();

            var result = Calculator.Subtract(10, 5);
            
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DivideTest()
        {
            var sut = new Calculator();

            var result = Calculator.Divide(10, 2);
            
            Assert.That(result, Is.EqualTo(5));
            
        }

        [Test]
        public void MultiplyTest()
        {
            var sut = new Calculator();

            var result = Calculator.Multiply(10, 10);
            
            Assert.That(result, Is.EqualTo(100));
        }
        
    }
    

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            return 1;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
  
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var calcTest = new CalculatorTests();
            calcTest.AddTest();
            calcTest.SubtractTest();
            calcTest.DivideTest();
            calcTest.MultiplyTest();
            
            var calc = new Calculator();
            Console.WriteLine("100 + 157 = " + Calculator.Add(100, 157));

        }
    }
}