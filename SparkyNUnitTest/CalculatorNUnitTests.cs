using Calculator.App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
       [Test]
       public void AddNumbers_InputTwoInt_GetAddition()
        {
            //Arrange
            Calculator.App.Calculator cal = new();

            //Act
            int result = cal.AddNumbers(10, 20);

            //Assertion
            Assert.AreEqual(30, result);
        }

        [Test]
        public void CheckOddChecker_InputEvenNumber_Result_False()  
        {
            //Arrange
            Calculator.App.Calculator cal = new();

            //Act
            bool isOdd = cal.IsOddNumber(10);

            //Assertion
            Assert.That(isOdd, Is.EqualTo(false));
            //Assert.IsFalse(isOdd);
        }


        [Test]
        public void CheckOddChecker_InputOddNumber_Result_True()
        {
            //Arrange 
            Calculator.App.Calculator cal = new(); 

            //Act
            bool isOdd = cal.IsOddNumber(11);

            //Assertion
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }


        [Test]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(15)]
        public void IsOddChecker_InputOffNumber_Result_True(int a)  
        {
            //Arrange 
            Calculator.App.Calculator cal = new();

            //Act
            bool isOdd = cal.IsOddNumber(a);

            //Assertion
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_Result_TrueIfOdd(int a)
        {
            Calculator.App.Calculator cal = new(); 
            return cal.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] //15.93
        [TestCase(5.49, 10.59)] //16.08
        public void AddNumbersDouble_InputDouble_GetCorrectAddition(double a, double b)
        {
            //Arrange
            Calculator.App.Calculator cal = new();
            //Act
            double result = cal.AddNumbersDouble(a, b);

            //Assert

            Assert.AreEqual(15.9, result, 1);

        }

    }
}

//Running tutorials: 006 section-03