namespace SampleEstructure.MedicalCenters.Aplication.Create
{
    public class CreateMedicalCenterCommand
    {
        public string MedicalCenterGuid { get; set; }
        public string MedicalCenterName { get; private set; }
        public int UbigeoId { get; private set; }
        public string Address { get; private set; }
        public string RepresentativeName { get; private set; }
        public string CompanyGuid { get; private set; }
        public string CreationUser { get; private set; }
        private CreateMedicalCenterCommand(string MedicalCenterGuid,string MedicalCenterName,int UbigeoId, string Address, string RepresentativeName, string CompanyGuid, string CreationUser)
        {
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.MedicalCenterName = MedicalCenterName;
            this.UbigeoId = UbigeoId;
            this.Address = Address;
            this.RepresentativeName = RepresentativeName;
            this.CompanyGuid = CompanyGuid;
            this.CreationUser = CreationUser;
        }
        public static CreateMedicalCenterCommand Create(string MedicalCenterGuid,string MedicalCenterName, int UbigeoId, string Address, string RepresentativeName, string CompanyGuid, string CreationUser)
        {
            CreateMedicalCenterCommand createMedicalCenterCommand = new CreateMedicalCenterCommand(MedicalCenterGuid,MedicalCenterName, UbigeoId,Address,RepresentativeName,CompanyGuid, CreationUser);
            return createMedicalCenterCommand;
        }
    }
}