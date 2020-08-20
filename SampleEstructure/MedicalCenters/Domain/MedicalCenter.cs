using SampleEstructure.Shared.Domain.ValueObject;
using System.Collections.Generic;
namespace SampleEstructure.MedicalCenters.Domain
{
    public class MedicalCenter
    {
        public GuidValueObject MedicalCenterGuid { get; private set; }
        public StringValueObject MedicalCenterName { get; private set; }
        public IntValueObject UbigeoId { get; private set; }
        public AlphanumericValueObject Address { get; private set; }
        public StringValueObject RepresentativeName { get; private set; }
        public GuidValueObject CompanyGuid { get; private set; }
        public bool Active { get; private set; }
        public ICollection<MedicalCenterSpecialist> MedicalCenterSpecialists { get; private set; }
        //public List<MedicalCenterSpeciality> medicalCenterSpecialities { get; private set; }

        private MedicalCenter(GuidValueObject MedicalCenterGuid, StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address, StringValueObject RepresentativeName, GuidValueObject CompanyGuid,bool Active )
        {
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.MedicalCenterName = MedicalCenterName;
            this.UbigeoId = UbigeoId;
            this.Address = Address;
            this.RepresentativeName = RepresentativeName;
            this.CompanyGuid = CompanyGuid;
            this.Active = Active;
            this.MedicalCenterSpecialists = new HashSet<MedicalCenterSpecialist>();
        }
        public static MedicalCenter Create(GuidValueObject MedicalCenterGuid, StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address, StringValueObject RepresentativeName,
        GuidValueObject CompanyGuid, bool Active)
        {
            MedicalCenter medicalCenter = new MedicalCenter(MedicalCenterGuid, MedicalCenterName, UbigeoId, Address, RepresentativeName, CompanyGuid, Active);
            //Agregar eventos de dominio si los huviera
            return medicalCenter;
        }
        #region Specialist
        public void AddSpecialist(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid)
        {
            MedicalCenterSpecialist medicalCenterSpeciality = MedicalCenterSpecialist.Create(MedicalCenterSpecialistGuid, SpecialistGuid, this.MedicalCenterGuid, true);
            this.MedicalCenterSpecialists.Add(medicalCenterSpeciality);
        }
        //public void AnulateSpecialist(GuidValueObject MedicalCenterSpecialistGuid)
        //{
        //     //this.medicalCenterSpecialists.SingleOrDefault(x => x.MedicalCenterSpecialistGuid.Equals(MedicalCenterSpecialistGuid)).;
        //}
        //public void SetmedicalCenterSpecialists(List<MedicalCenterSpecialist> medicalCenterSpecialists)
        //{
        //    this.medicalCenterSpecialists = medicalCenterSpecialists;
        //}
        #endregion
        #region Specialist
        //public void SetmedicalCenterSpecialities(List<MedicalCenterSpeciality> medicalCenterSpecialities)
        //{
        //    this.medicalCenterSpecialities = medicalCenterSpecialities;
        //}
        //public void AddSpeciality(GuidValueObject MedicalCenterSpecialityGuid, GuidValueObject MedicalCenterGuid, GuidValueObject SpecialityGuid,
        //bool Active, DateTime? CreationDate, Email CreationUser, DateTime? ModificationDate, Email ModificationUser)
        //{
        //    MedicalCenterSpeciality medicalCenterSpeciality = MedicalCenterSpeciality.Create(MedicalCenterSpecialityGuid, MedicalCenterGuid, SpecialityGuid, Active, CreationDate, CreationUser, ModificationDate, ModificationUser);
        //    this.MedicalCenterSpecialities.Add(medicalCenterSpeciality);
        //}
        //public void AnulateSpeciality(GuidValueObject MedicalCenterSpecialityGuid)
        //{
        //    this.medicalCenterSpecialities.SingleOrDefault(x => x.MedicalCenterSpecialityGuid.Equals(MedicalCenterSpecialityGuid)).Active = false;
        //}
        #endregion
    }
}