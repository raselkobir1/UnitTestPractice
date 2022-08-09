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
    }
}

//Running tutorials: 006 section-03