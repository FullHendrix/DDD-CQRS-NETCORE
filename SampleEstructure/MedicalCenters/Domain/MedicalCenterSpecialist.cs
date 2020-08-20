using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.MedicalCenters.Domain
{
    public class MedicalCenterSpecialist
    {
        public GuidValueObject  MedicalCenterSpecialistGuid { get; private set; }
        public GuidValueObject SpecialistGuid { get; private set; }
        public GuidValueObject MedicalCenterGuid { get; private set; }
        public bool Active { get; private set; }
        public MedicalCenter MedicalCenter { get; private set; }
        private MedicalCenterSpecialist(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid,bool Active)
        {
            this.MedicalCenterSpecialistGuid = MedicalCenterSpecialistGuid;
            this.SpecialistGuid = SpecialistGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.Active = Active;
        }
        public static MedicalCenterSpecialist Create(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid,bool Active)
        {
            return new MedicalCenterSpecialist(MedicalCenterSpecialistGuid, SpecialistGuid, MedicalCenterGuid, Active);
        }
    }
}