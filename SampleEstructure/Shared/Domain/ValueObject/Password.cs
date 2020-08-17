using System;
using System.Text.RegularExpressions;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class Password
    {
        public string  Value { get; private set; }
        public Password(string value)
        {
            if (value == null) throw new FormatException("Password doesn't can be null.");
            IsPasswordValid(value);
            Value = value;
        }
        #region Guard
        private void IsPasswordValid( string value)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])[A-Za-z\d$@$!.%*?&]{8,15}[^'\s]$";
            Match passwordlMatch = Regex.Match(value, pattern);
            if (!passwordlMatch.Success)
            {
                throw new FormatException("The password requires between 8 and 15 characters between uppercase, lowercase and symbols(@$!.%*)");
            }
        }
        #endregion
    }
}