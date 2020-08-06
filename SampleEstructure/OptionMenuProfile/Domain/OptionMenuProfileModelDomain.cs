using System;
namespace SampleEstructure.OptionMenuProfile.Domain
{
    public class OptionMenuProfileModelDomain
    {
        public Guid OptionMenuProfileGuid { get; set; }
        public Guid ProfileGuid { get; set; }
        public Guid OptionMenuGuid { get; set; }
        public bool Active { get; set; }
        public Guid CompanyGuid { get; set; }
        public DateTime CreacionDate { get; set; }
        public Guid CreationUserGuid { get; set; }
        public DateTime? ModificationDate { get; set; }
        public Guid? ModificationUserGuid{ get; set; }
    }
}