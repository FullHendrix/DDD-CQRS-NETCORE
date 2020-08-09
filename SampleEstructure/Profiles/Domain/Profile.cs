using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Profiles.Domain
{
    public class Profile : DomainModel
    {
        //Propiedades en español, por consistencia con BD 
        public GuidValueObject ProfileGuid { get; set; }
        public StringValueObject ProfileName { get; set; }
        public bool IsPacient { get; set; }
        public GuidValueObject CompanyGuid { get; set; }
    }
}