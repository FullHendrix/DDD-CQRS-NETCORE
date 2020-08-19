namespace SampleEstructure.MedicalCenters.Aplication.Read
{
    public class ReadMedicalCenterQuery
    {
        public string MedicalCenterGuid { get;  private set; }
        private ReadMedicalCenterQuery(string MedicalCenterGuid)
        {
            this.MedicalCenterGuid = MedicalCenterGuid;
        }
        public static ReadMedicalCenterQuery Create(string MedicalCenterGuid)
        {
            return new ReadMedicalCenterQuery(MedicalCenterGuid);
        }
    }
}
