using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.OptionMenuProfiles.Domain
{
    public class OptionMenuProfile : DomainModel
    {
        public GuidValueObject OptionMenuProfileGuid { get; set; }
        public GuidValueObject ProfileGuid { get; set; }
        public GuidValueObject OptionMenuGuid { get; set; }
        public GuidValueObject CompanyGuid { get; set; }
    }
}