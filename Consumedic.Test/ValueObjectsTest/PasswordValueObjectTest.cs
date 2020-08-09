using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consumedic.Test.ValueObjectsTest
{
    [TestClass]
    class PasswordValueObjectTest
    {
        [TestMethod]
        public void PasswordCorrectFormat()
        {
            Password password = new Password("2875849ca");
                 
        }
        [TestMethod]
        public void PasswordIncorrectFormat()
        {
            Password password = new Password("123456");
        }
    }
}
