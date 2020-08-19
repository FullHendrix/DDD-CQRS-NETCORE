using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.MedicalCenters.Aplication.AddSpecialist
{
    public class MedicalCenterSpecialistAdder
    {
        MedicalCenterRepository _medicalCenterRepository;
        public MedicalCenterSpecialistAdder(MedicalCenterRepository medicalCenterRepository)
        {
            _medicalCenterRepository = medicalCenterRepository;
        }
        public void Add(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid,bool Active)
        { 
            MedicalCenterSpecialist medicalCenterSpecialist = MedicalCenterSpecialist.Create(MedicalCenterSpecialistGuid, SpecialistGuid, MedicalCenterGuid, Active);
            _medicalCenterRepository.AddSpecialist(medicalCenterSpecialist);
        }
    }
}