using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using System;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class GuidValueObject
    {
        public Guid Value { get; private set; }
        GeneralRepository<Company> _CompanyRepository;
        public GuidValueObject(string value)
        {
            Guid guidValue = isValidaGuid(value);
            Value = guidValue;
        }
        #region Guard
        private Guid isValidaGuid(string Value)
        {
            Guid guidResult;
            if (!Guid.TryParse(Value, out guidResult)) throw new FormatException("Invalid format of GUID");
            return guidResult;
        }
        #endregion
    }
}
