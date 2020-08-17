using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
namespace Consumedic.Test.ValueObjectsTest
{
    [TestClass]
    public class EmailValueObjectTest
    {
        [TestMethod]
        public void EmailCorrectFormat()
        {
            string Email = "cespejo25@gmail.com";
            Email email = new Email(Email);
            Assert.IsTrue(email.Value.Equals(Email));
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmailIncorrectFomat()
        {
            string Email = "cespejo25gmail.com";
            Email email = new Email(Email);
            Assert.IsTrue(email.Value.Equals(Email));
        }
        [TestMethod]
        public void EmailIncorrectNullFomat()
        {
            string Email = null;
            Email email = new Email(Email);
            Assert.IsTrue(email.Value == Email);
        }
    }
}