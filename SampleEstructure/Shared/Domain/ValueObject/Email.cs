using System;
using System.Text.RegularExpressions;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class Email
    {
        public string Value { get; }
        public Email(string value)
        {
            IsValidEmai(value);
            Value = value;
        }
        #region Guard
        void IsValidEmai(string value)
        {
            string pattern = @"/[a - zA - Z0 - 9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?/";
            Match emailMatch = Regex.Match(value, pattern);
            if (!emailMatch.Success)
            {
                throw new FormatException("Invalid format to email");
            }
        }
        #endregion
    }
}