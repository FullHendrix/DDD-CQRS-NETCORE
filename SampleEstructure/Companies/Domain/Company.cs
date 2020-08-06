using SampleEstructure.Shared.Domain;
using System;
namespace SampleEstructure.Companies.Domain
{
    public class Company : DomainModel
    {
        public Guid CompanyGuid { get; set; }
        public string CompanyNanme { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public Guid LegalRepresentativeGuid { get; set; }
    }
}
