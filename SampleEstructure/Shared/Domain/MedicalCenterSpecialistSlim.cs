using System;
namespace SampleEstructure.Shared.Domain
{
    public class MedicalCenterSpecialistSlim
    {
        public Guid MedicalCenterSpecialistGuid { get; private set; }
        public Guid SpecialistGuid { get; private set; }
        public Guid MedicalCenterGuid { get; private set; }
        public bool Active { get; private set; }
        public MedicalCenterSlim MedicalCenter { get; private set; }
        private MedicalCenterSpecialistSlim(Guid MedicalCenterSpecialistGuid, Guid SpecialistGuid, Guid MedicalCenterGuid)
        {
            this.MedicalCenterSpecialistGuid = MedicalCenterSpecialistGuid;
            this.SpecialistGuid = SpecialistGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
        }
        public static MedicalCenterSpecialistSlim Create(Guid MedicalCenterSpecialistGuid, Guid SpecialistGuid, Guid MedicalCenterGuid)
        {
            return new MedicalCenterSpecialistSlim(MedicalCenterSpecialistGuid, SpecialistGuid, MedicalCenterGuid);
        }
    }
}