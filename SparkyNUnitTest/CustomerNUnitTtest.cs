using Calculator.App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparkyNUnitTest
{
    public class CustomerNUnitTtest
    {
        private Customer? customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer(); 
        }

        [Test]
        public void InputFnameand_LName_ReturnGreatingWithFullName()
        {
            //Arrange
            //Customer customer = new Customer();

            //Act
            customer.GreetAndGetFullName("Abdur", "Rahman");

            //Assert
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Abdur Rahman"));
            Assert.AreEqual(customer.GreetMessage, "Hello, Abdur Rahman");
            Assert.That(customer.GreetMessage, Does.Contain(","));
            Assert.That(customer.GreetMessage, Does.Contain("Abdur Rahman").IgnoreCase);
            Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
            Assert.That(customer.GreetMessage, Does.EndWith("Rahman"));
            Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }
        [Test]
        public void GreetMessage_NotGreeted_Return_null()
        {
            //Arrange
            //var customer = new Customer();
            //Act
                    //check value null or not
            //Assert
            Assert.IsNull(customer.GreetMessage);
        }
    }
}


// Working on Section- 4 tutorial-1