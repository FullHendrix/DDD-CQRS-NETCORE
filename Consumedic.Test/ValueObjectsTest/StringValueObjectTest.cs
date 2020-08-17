using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace Consumedic.Test.ValueObjectsTest
{
    [TestClass]
    public class StringValueObjectTest
    {
        [TestMethod]
        public void StringNullCorrectFormat()
        {
            StringValueObject stringValueObject = new StringValueObject(null);
            Assert.IsTrue(stringValueObject.Value == null);
        }
        [TestMethod]
        public void StringCorrectFormatName()
        {
            string Value = "Carlos Espejo";
            StringValueObject stringValueObject = new StringValueObject(Value);
            Assert.IsTrue(stringValueObject.Value.Equals(Value));
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void StringIncorrectFormatName()
        {
            string Value = "Carlos Espejo 25";
            StringValueObject stringValueObject = new StringValueObject(Value);
            Assert.IsTrue(stringValueObject.Value.Equals(Value));
        }
        [TestMethod]
        public void StringCorrectLongText()
        {
            string Value = "Lorem Ipsum";
            StringValueObject stringValueObject = new StringValueObject(Value);
            Assert.IsTrue(stringValueObject.Value.Equals(Value));
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void StringIncorrectLongText()
        {
            string Value = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s";
            StringValueObject stringValueObject = new StringValueObject(Value);
            Assert.IsTrue(stringValueObject.Value.Equals(Value));
        }
    }
}