using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTestPoject
{
    public class Tests
    {
        private CalculatorClass CalculatorClassObject;

        [SetUp]
        public void Setup()
        {
            CalculatorClassObject = new CalculatorClass();
        }

        [Test]
        public void AdditionTest()
        {
            Assert.AreEqual(10.0, CalculatorClassObject.Addition(5.0, 5.0));
            Assert.AreEqual(0.0, CalculatorClassObject.Addition(5.0, -5.0));
            Assert.AreEqual(-10.0, CalculatorClassObject.Addition(-5.0, -5.0));
            Assert.AreEqual(5.0, CalculatorClassObject.Addition(0.0, 5.0));
        }

        [Test]
        public void GreaterThanLargestDoubleNumberAdditionTest()
        {
           // Assert.Throws< ArgumentOutOfRangeException> (() => 
            //CalculatorClassObject.Addition(1.7976931348623157E+308, 1.7976931348623157E+308));
        }

        [Test]
        public void SubtractionTest()
        {
            Assert.AreEqual(0, CalculatorClassObject.Subtraction(5, 5));
            Assert.AreEqual(10, CalculatorClassObject.Subtraction(5, -5));
            Assert.AreEqual(0, CalculatorClassObject.Subtraction(-5, -5));
            Assert.AreEqual(-5, CalculatorClassObject.Subtraction(0, 5));
        }

        [Test]
        public void MultiplicationTest()
        {
            Assert.AreEqual(25.0, CalculatorClassObject.Multiplication(5.0, 5.0));
            Assert.AreEqual(-25.0, CalculatorClassObject.Multiplication(5.0, -5.0));
            Assert.AreEqual(25.0, CalculatorClassObject.Multiplication(-5.0, -5.0));
            Assert.AreEqual(0.0, CalculatorClassObject.Multiplication(0.0, 5.0));
        }

        [Test]
        public void DivisionTest()
        {
            Assert.AreEqual(1.0, CalculatorClassObject.Division(5.0, 5.0));
            Assert.AreEqual(-1.0, CalculatorClassObject.Division(5.0, -5.0));
            Assert.AreEqual(1.0, CalculatorClassObject.Division(-5.0, -5.0));
            Assert.AreEqual(0.0, CalculatorClassObject.Division(0.0, 5.0));
        }

        [Test]
        public void DivisionByZeroTest()
        {
            Assert.Throws<DivideByZeroException>(() => CalculatorClassObject.Division(5, 0));
        }
    }
}