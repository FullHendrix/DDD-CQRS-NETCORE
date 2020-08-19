using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.MedicalCenters.Aplication.Create
{
    class MedicalCenterCreator
    {
        MedicalCenterRepository _medicalCenterRepository;
        public MedicalCenterCreator(MedicalCenterRepository medicalCenterRepository)
        {
            _medicalCenterRepository = medicalCenterRepository;
        }
        public void Create(GuidValueObject MedicalCenterGuid,StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address, StringValueObject RepresentativeName, GuidValueObject CompanyGuid)
        {
            MedicalCenter medicalCenter = MedicalCenter.Create(MedicalCenterGuid,MedicalCenterName,UbigeoId,Address,RepresentativeName,CompanyGuid,true);
            _medicalCenterRepository.Create(medicalCenter);
        }
    }
}