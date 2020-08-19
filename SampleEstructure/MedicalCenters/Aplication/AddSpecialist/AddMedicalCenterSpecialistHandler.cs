using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.MedicalCenters.Aplication.AddSpecialist
{
    public class AddMedicalCenterSpecialistHandler
    {
        MedicalCenterRepository _MedicalCenterRepository;
        public AddMedicalCenterSpecialistHandler(MedicalCenterRepository MedicalCenterRepository)
        {
            _MedicalCenterRepository = MedicalCenterRepository;
        }
        public void Handle(AddMedicalCenterSpecialistCommand addSpecialistCommand)
        {
            GuidValueObject MedicalCenterSpecialistGuid = new GuidValueObject(addSpecialistCommand.MedicalCenterSpecialistGuid);
            GuidValueObject SpecialistGuid = new GuidValueObject(addSpecialistCommand.SpecialistGuid);
            GuidValueObject MedicalCenterGuid = new GuidValueObject(addSpecialistCommand.MedicalCenterGuid);
            bool Active = true;
            MedicalCenterSpecialistAdder specialistAdder = new MedicalCenterSpecialistAdder(_MedicalCenterRepository);
            specialistAdder.Add(MedicalCenterSpecialistGuid, SpecialistGuid,MedicalCenterGuid,Active);
        }
    }
}