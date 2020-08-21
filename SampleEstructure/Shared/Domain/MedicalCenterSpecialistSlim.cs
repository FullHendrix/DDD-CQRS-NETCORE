using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Shared.Domain
{
    public class MedicalCenterSpecialistSlim
    {
        public GuidValueObject MedicalCenterSpecialistGuid { get; private set; }
        public GuidValueObject SpecialistGuid { get; private set; }
        //public Guid MedicalCenterGuid { get; private set; }
        public GuidValueObject MedicalCenterGuid { get; private set; }
        public bool Active { get; private set; }
        public MedicalCenterSlim MedicalCenter { get; private set; }
        private MedicalCenterSpecialistSlim(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid)
        {
            this.MedicalCenterSpecialistGuid = MedicalCenterSpecialistGuid;
            this.SpecialistGuid = SpecialistGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
        }
        public static MedicalCenterSpecialistSlim Create(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid)
        {
            return new MedicalCenterSpecialistSlim(MedicalCenterSpecialistGuid, SpecialistGuid, MedicalCenterGuid);
        }
    }
}