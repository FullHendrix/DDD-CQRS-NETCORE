using System;
using System.Text.RegularExpressions;

namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class Password
    {
        public string  Value { get; }
        public Password(string value)
        {
            IsPasswordValid(value);
            Value = value;
        }
        #region Guard
        private void IsPasswordValid( string value)
        {
            string pattern = @"/^(?=.*[a - z])(?=.*[A - Z])(?=.*\d)(?=.*[$@$!% *? &])([A - Za - z\d$@$!% *? &] |[^ ]){ 8,15}$/";
            Match passwordlMatch = Regex.Match(value, pattern);
            if (!passwordlMatch.Success)
            {
                throw new FormatException("La contraseña no cumple las condiciones de seguridad");
            }
        }
        #endregion
    }
}