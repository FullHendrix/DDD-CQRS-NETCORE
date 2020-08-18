using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleEstructure.MedicalCenters.Domain
{
    public class MedicalCenterSpecialist : DomainModel
    {
        public GuidValueObject  MedicalCenterSpecialistGuid { get; private set; }
        public GuidValueObject SpecialistGuid { get; private set; }
        public GuidValueObject MedicalCenterGuid { get; private set; }
        public MedicalCenterSpecialist()
        {

        }
        private MedicalCenterSpecialist(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid,
        bool Active, DateTime? CreationDate, Email CreationUser ,DateTime? ModificationDate,Email ModificationUser )
        {
            this.MedicalCenterSpecialistGuid = MedicalCenterSpecialistGuid;
            this.SpecialistGuid = SpecialistGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.Active = Active;
            this.CreationDate = CreationDate;
            this.CreationUser = CreationUser;
            this.ModificationDate = ModificationDate;
            this.ModificationUser = ModificationUser;

        }
        public static MedicalCenterSpecialist Create(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid,
        bool Active, DateTime? CreationDate, Email CreationUser, DateTime? ModificationDate, Email ModificationUser)
        {
            MedicalCenterSpecialist medicalCenterSpecialist = new MedicalCenterSpecialist(MedicalCenterSpecialistGuid, SpecialistGuid, MedicalCenterGuid, Active, 
            CreationDate, CreationUser, ModificationDate, ModificationUser);
            return medicalCenterSpecialist;
        }
    }
}