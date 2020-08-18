using System;
using System.Text.RegularExpressions;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class AlphanumericValueObject
    {
        public string Value { get; private set; }
        public AlphanumericValueObject( string Value)
        {
            if (Value != null)
            {
                IsValidAlphanumeric(Value);
                IsToLongAlphanumeric(Value);
            }
            this.Value = Value;
        }
        private void IsValidAlphanumeric(string Value)
        {
            Value = Value.Trim();
            string Pattern = @"^[a-zA-Z0-9ñ.()/-/-\s]{0,100}$";
            Match match = Regex.Match(Value, Pattern);
            if (!match.Success) throw new FormatException("Invalid format to string.");
        }
        private void IsToLongAlphanumeric(string Value)
        {
            if (Value.Trim().Length > 200) throw new FormatException("The maximum length of a string is set to 100 characters.");
        }
    }
}