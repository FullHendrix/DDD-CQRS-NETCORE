namespace SampleEstructure.MedicalCenters.Aplication.AddSpecialist
{
    public class AddMedicalCenterSpecialistCommand
    {
        public string MedicalCenterSpecialistGuid { get; private set; }
        public string SpecialistGuid { get; private set; }
        public string MedicalCenterGuid { get; private set; }
        private AddMedicalCenterSpecialistCommand( string MedicalCenterSpecialistGuid, string SpecialistGuid, string MedicalCenterGuid)
        {
            this.MedicalCenterSpecialistGuid = MedicalCenterSpecialistGuid;
            this.SpecialistGuid = SpecialistGuid;
            this.MedicalCenterGuid = MedicalCenterGuid;
        }
        public static AddMedicalCenterSpecialistCommand Create(string MedicalCenterSpecialistGuid, string SpecialistGuid, string MedicalCenterGuid)
        {
            AddMedicalCenterSpecialistCommand addSpecialistCommand = new AddMedicalCenterSpecialistCommand(MedicalCenterSpecialistGuid, SpecialistGuid,MedicalCenterGuid);
            return addSpecialistCommand;
        }
    }
}