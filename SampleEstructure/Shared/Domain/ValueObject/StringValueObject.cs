using System;
using System.Text.RegularExpressions;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class StringValueObject 
    {
        public string Value { get; private set; }
        public StringValueObject(string value)
        {
            IsValidString(value);
            Value = value.Trim();
        }
        #region Guard
        private void IsValidString(string Value)
        {
            string Pattern = @"[a-zA-Z\s]{0,100}";
            Match match = Regex.Match(Value, Pattern );
            if (!match.Success) throw new FormatException("Invalid format to string");
        }
        #endregion
    }
}
