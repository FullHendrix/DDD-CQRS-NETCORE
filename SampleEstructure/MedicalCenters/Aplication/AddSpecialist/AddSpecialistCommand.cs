namespace SampleEstructure.MedicalCenters.Aplication.AddSpecialist
{
    public class AddSpecialistCommand
    {
        public string MedicalCenterSpecialistGuid { get; private set; }
        public string SpecialistGuid { get; private set; }
        public string MedicalCenterGuid { get; private set; }
        public string CreationUser { get; private set; }
        private AddSpecialistCommand( string MedicalCenterSpecialistGuid, string SpecialistGuid, string MedicalCenterGuid, string CreationUser)
        {
            this.MedicalCenterSpecialistGuid = MedicalCenterSpecialistGuid;
            this.SpecialistGuid = SpecialistGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
            this.CreationUser = CreationUser;            
        }
        public static AddSpecialistCommand Add(string MedicalCenterSpecialistGuid, string SpecialistGuid, string MedicalCenterGuid, string CreationUser)
        {
            AddSpecialistCommand addSpecialistCommand = new AddSpecialistCommand(MedicalCenterSpecialistGuid, SpecialistGuid,MedicalCenterGuid,CreationUser);
            return addSpecialistCommand;
        }
    }
}