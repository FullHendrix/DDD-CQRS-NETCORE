using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
namespace Consumedic.Test.ValueObjectsTest
{
    [TestClass]
    class EmailValueObjectTest
    {
        [TestMethod]
        public void EmailCorrectFormat()
        {
            Email email = new Email("cespejo25@gmail.com");
            //Assert.AreEqual(email)
        }
        [TestMethod]
        public void EmailIncorrectFomat()
        {
            Email email = new Email("cespejo25gmail.com");
        }
    }
}