using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Companies.Domain
{
    public class Company : DomainModel
    {
        public GuidValueObject CompanyGuid { get; set; }
        public StringValueObject CompanyNanme { get; set; }
        public IntValueObject DocumentType { get; set; }
        public AlphanumericValueObject DocumentNumber { get; set; }
        public GuidValueObject LegalRepresentativeGuid { get; set; }
    }
}