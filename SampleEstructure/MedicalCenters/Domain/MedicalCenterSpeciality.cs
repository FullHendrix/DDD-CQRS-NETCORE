using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.MedicalCenters.Domain
{
    public class MedicalCenterSpeciality : DomainModel
    {
        public GuidValueObject MedicalCenterSpecialityGuid { get; private set; }
        public GuidValueObject MedicalCenterGuid { get; private set; }
        public GuidValueObject SpecialityGuid { get;  private set; }
        private MedicalCenterSpeciality(GuidValueObject MedicalCenterSpecialityGuid, GuidValueObject MedicalCenterGuid, GuidValueObject SpecialityGuid, 
        bool Active, DateTime? CreationDate, Email CreationUser, DateTime? ModificationDate, Email ModificationUser)
        {
            this.MedicalCenterSpecialityGuid = MedicalCenterSpecialityGuid;
            this.SpecialityGuid = SpecialityGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.Active = Active;
            this.CreationDate = CreationDate;
            this.CreationUser = CreationUser;
            this.ModificationDate = ModificationDate;
            this.ModificationUser = ModificationUser;
        }
        public MedicalCenterSpeciality Create(GuidValueObject MedicalCenterSpecialityGuid, GuidValueObject MedicalCenterGuid, GuidValueObject SpecialityGuid,
        bool Active, DateTime? CreationDate, Email CreationUser, DateTime? ModificationDate, Email ModificationUser)
        {
            return new MedicalCenterSpeciality(MedicalCenterSpecialityGuid,MedicalCenterGuid,SpecialityGuid,Active,CreationDate,CreationUser,ModificationDate,ModificationUser);
        }
    }
}