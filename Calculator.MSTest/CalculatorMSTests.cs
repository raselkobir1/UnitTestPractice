using Calculator.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MSTest
{
    [TestClass]
    public class CalculatorMSTests 
    {
         [TestMethod]
         public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Summation sum = new();

            //Act
            int result = sum.AddNumbers(10, 20);

            //Assertion
            Assert.AreEqual(30, result); 

        }
    }
}
