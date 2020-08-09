using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
namespace Consumedic.Test.ValueObjectsTest
{
    [TestClass]
    class StringValueObjectTest
    {
        [TestMethod]
        public void StringCorrectFormat()
        {
            StringValueObject stringValueObject = new StringValueObject("");
        }
        [TestMethod]
        public void StringIncorrectFormatName()
        {
            StringValueObject stringValueObject = new StringValueObject("Carlos Espejo Huerta");
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void StringIncorrectFormatAddres()
        {
            StringValueObject stringValueObject = new StringValueObject("Mz N Lt 12 Gr 27 Sc 3");
        }
    }
}