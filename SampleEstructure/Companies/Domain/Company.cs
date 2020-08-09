using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Companies.Domain
{
    public class Company : DomainModel
    {
        public GuidValueObject CompanyGuid { get; set; }
        public string CompanyNanme { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public GuidValueObject LegalRepresentativeGuid { get; set; }
    }
}
