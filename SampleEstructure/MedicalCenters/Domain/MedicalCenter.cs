using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleEstructure.MedicalCenters.Domain
{
    public class MedicalCenter : DomainModel
    {
        public GuidValueObject MedicalCenterGuid { get; private set; }
        public StringValueObject MedicalCenterName { get; private set; }
        public IntValueObject UbigeoId { get; private set; }
        public AlphanumericValueObject Address { get; private set; }
        public StringValueObject RepresentativeName { get; private set; }
        public GuidValueObject CompanyGuid { get; private set; }
        public List<MedicalCenterSpecialist> medicalCenterSpecialists { get; private set; }
        public List<MedicalCenterSpeciality> medicalCenterSpecialities { get; private set; }
        private MedicalCenter(GuidValueObject MedicalCenterGuid, StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address, StringValueObject RepresentativeName, GuidValueObject CompanyGuid, 
        Email CreationUser)
        {
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.MedicalCenterName = MedicalCenterName;
            this.UbigeoId = UbigeoId;
            this.Address = Address;
            this.RepresentativeName = RepresentativeName;
            this.CompanyGuid = CompanyGuid;
            this.CreationUser = CreationUser;
            this.CreationDate = DateTime.Now;
            this.ModificationUser = CreationUser;
        }
        public void SetmedicalCenterSpecialists(List<MedicalCenterSpecialist> medicalCenterSpecialists)
        {
            this.medicalCenterSpecialists = medicalCenterSpecialists;
        }
        public void SetmedicalCenterSpecialities(List<MedicalCenterSpeciality> medicalCenterSpecialities)
        {
            this.medicalCenterSpecialities = medicalCenterSpecialities;
        }
        public static MedicalCenter Create(GuidValueObject MedicalCenterGuid, StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address, StringValueObject RepresentativeName, 
        GuidValueObject CompanyGuid, Email CreationUser)
        {
            MedicalCenter medicalCenter = new MedicalCenter(MedicalCenterGuid, MedicalCenterName, UbigeoId, Address, RepresentativeName, CompanyGuid, CreationUser);
            //Agregar eventos de dominio si los huviera
            return medicalCenter;
        }
    }
}