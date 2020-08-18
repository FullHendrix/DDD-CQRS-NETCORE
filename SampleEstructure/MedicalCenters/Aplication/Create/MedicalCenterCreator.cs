using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.MedicalCenters.Aplication.Create
{
    class MedicalCenterCreator
    {
        MedicalCenterRepository _GeneralRepository;
        public MedicalCenterCreator(MedicalCenterRepository GeneralRepository)
        {
            _GeneralRepository = GeneralRepository;
        }
        public void Create(GuidValueObject MedicalCenterGuid,StringValueObject MedicalCenterName, IntValueObject UbigeoId, AlphanumericValueObject Address, StringValueObject RepresentativeName, GuidValueObject CompanyGuid, Email CreationUser)
        {
            MedicalCenter medicalCenter = MedicalCenter.Create(MedicalCenterGuid,MedicalCenterName,UbigeoId,Address,RepresentativeName,CompanyGuid,CreationUser);
            _GeneralRepository.Create(medicalCenter);
            MedicalCenter m = _GeneralRepository.Read(MedicalCenterGuid);
        }
    }
}