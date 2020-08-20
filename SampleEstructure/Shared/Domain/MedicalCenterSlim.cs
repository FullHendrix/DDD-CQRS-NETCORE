using System;
using System.Collections.Generic;
namespace SampleEstructure.Shared.Domain
{
    public class MedicalCenterSlim
    {
        public Guid MedicalCenterGuid { get; private set; }
        public string MedicalCenterName { get; private set; }
        public int UbigeoId { get; private set; }
        public string Address { get; private set; }
        public string RepresentativeName { get; private set; }
        public Guid CompanyGuid { get; private set; }
        public bool Active { get; private set; }
        public ICollection<MedicalCenterSpecialistSlim> MedicalCenterSpecialists { get; private set; }
        private MedicalCenterSlim(Guid MedicalCenterGuid, string MedicalCenterName, int UbigeoId, string Address, string RepresentativeName, Guid CompanyGuid )
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
        public static MedicalCenterSlim Create(Guid MedicalCenterGuid, string MedicalCenterName, int UbigeoId, string Address, string RepresentativeName, Guid CompanyGuid)
        {
            return new MedicalCenterSlim(MedicalCenterGuid, MedicalCenterName, UbigeoId, Address, RepresentativeName, CompanyGuid);
        }
        public void AddMedicalCenterSpecialists(Guid MedicalCenterSpecialistGuid, Guid SpecialistGuid)
        {
            this.MedicalCenterSpecialists.Add(MedicalCenterSpecialistSlim.Create(MedicalCenterSpecialistGuid, SpecialistGuid, this.MedicalCenterGuid));
        }
    }
}