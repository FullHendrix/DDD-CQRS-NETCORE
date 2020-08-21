using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
namespace SampleEstructure.Shared.Domain
{
    public class MedicalCenterSlim
    {
        public GuidValueObject MedicalCenterGuid { get; private set; }
        //public Guid MedicalCenterGuid { get; private set; }
        public StringValueObject MedicalCenterName { get; private set; }
        public IntValueObject UbigeoId { get; private set; }
        public AlphanumericValueObject Address { get; private set; }
        public StringValueObject RepresentativeName { get; private set; }
        public GuidValueObject CompanyGuid { get; private set; }
        public bool Active { get; private set; }
        public ICollection<MedicalCenterSpecialistSlim> MedicalCenterSpecialists { get; private set; }
        private MedicalCenterSlim(GuidValueObject MedicalCenterGuid, StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address,
            StringValueObject RepresentativeName, GuidValueObject CompanyGuid)
        {
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.MedicalCenterName = MedicalCenterName;
            this.UbigeoId = UbigeoId;
            this.Address = Address;
            this.RepresentativeName = RepresentativeName;
            this.CompanyGuid = CompanyGuid;
            this.Active = true;
            this.MedicalCenterSpecialists = new HashSet<MedicalCenterSpecialistSlim>();
        }
        public static MedicalCenterSlim Create(GuidValueObject MedicalCenterGuid, StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address,
            StringValueObject RepresentativeName, GuidValueObject CompanyGuid)
        {
            return new MedicalCenterSlim(MedicalCenterGuid, MedicalCenterName, UbigeoId, Address, RepresentativeName, CompanyGuid);
        }
        public void AddMedicalCenterSpecialists(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid)
        {
            this.MedicalCenterSpecialists.Add(MedicalCenterSpecialistSlim.Create(MedicalCenterSpecialistGuid, SpecialistGuid, this.MedicalCenterGuid));
        }       
    }
}