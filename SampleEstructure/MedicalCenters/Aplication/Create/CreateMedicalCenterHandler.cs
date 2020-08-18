using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.MedicalCenters.Aplication.Create
{
    public class CreateMedicalCenterHandler
    {
        MedicalCenterRepository _medicalCenterRepository;
        public CreateMedicalCenterHandler(MedicalCenterRepository medicalCenterRepository)
        {
            _medicalCenterRepository = medicalCenterRepository;
        }
        public void Handle(CreateMedicalCenterCommand createMedicalCenterCommand)
        {
            GuidValueObject MedicalCenterGuid = new GuidValueObject(createMedicalCenterCommand.MedicalCenterGuid);
            StringValueObject MedicalCenterName = new StringValueObject(createMedicalCenterCommand.MedicalCenterName);
            IntValueObject UbigeoId = new IntValueObject(createMedicalCenterCommand.UbigeoId);
            AlphanumericValueObject Address = new AlphanumericValueObject(createMedicalCenterCommand.Address);
            StringValueObject RepresentativeName = new StringValueObject(createMedicalCenterCommand.RepresentativeName);
            GuidValueObject CompanyGuid = new GuidValueObject(createMedicalCenterCommand.CompanyGuid);
            Email CreationUser = new Email(createMedicalCenterCommand.CreationUser);
            MedicalCenterCreator medicalCenterCreator = new MedicalCenterCreator(_medicalCenterRepository);
            medicalCenterCreator.Create(MedicalCenterGuid, MedicalCenterName, UbigeoId, Address, RepresentativeName, CompanyGuid, CreationUser);
        }
    }
}