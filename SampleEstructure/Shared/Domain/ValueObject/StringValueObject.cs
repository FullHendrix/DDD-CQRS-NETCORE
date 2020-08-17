using System;
using System.Text.RegularExpressions;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class StringValueObject 
    {
        public string Value { get; private set; }
        public StringValueObject(string value)
        {
            if (value != null)
            {
                IsValidString(value);
                IsToLongText(value);
            }
            Value = value;
        }
        #region Guard
        private void IsValidString(string Value)
        {
            Value = Value.Trim();
            string Pattern = @"^[a-zA-Zñ\s]{0,100}$";
            Match match = Regex.Match(Value, Pattern);
            if (!match.Success) throw new FormatException("Invalid format to string.");
        }
        private void IsToLongText(string Value)
        {
            if (Value.Length > 100) throw new FormatException("The maximum length of a string is set to 100 characters.");
        }
        #endregion
    }
}