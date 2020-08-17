using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace Consumedic.Test.ValueObjectsTest
{
    [TestClass]
    public class PasswordValueObjectTest
    {
        [TestMethod]
        public void PasswordCorrectFormat()
        {
            string value = "Indrta.2020";
            Password password = new Password(value);
            Assert.IsTrue(password.Value.Equals(value));
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void PasswordIncorrectFormat()
        {
            string value = "123456";
            Password password = new Password(value);
            Assert.IsTrue(password.Value.Equals(value));
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void PasswordIncorrectNullFormat()
        {
            string value = null;
            Password password = new Password(value);
            Assert.IsTrue(password.Value.Equals(value));
        }
    }
}
