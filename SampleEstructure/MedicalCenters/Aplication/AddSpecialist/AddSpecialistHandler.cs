using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
namespace SampleEstructure.MedicalCenters.Aplication.AddSpecialist
{
    public class AddSpecialistHandler
    {
        GeneralRepository<MedicalCenter> _MedicalCenterRepository;
        public AddSpecialistHandler(GeneralRepository<MedicalCenter> MedicalCenterRepository)
        {
            _MedicalCenterRepository = MedicalCenterRepository;
        }
        public void Handle( AddSpecialistCommand addSpecialistCommand)
        {
            GuidValueObject MedicalCenterSpecialistGuid = new GuidValueObject(addSpecialistCommand.MedicalCenterSpecialistGuid);
            GuidValueObject SpecialistGuid = new GuidValueObject(addSpecialistCommand.SpecialistGuid);
            GuidValueObject MedicalCenterGuid = new GuidValueObject(addSpecialistCommand.MedicalCenterGuid);
            bool Active = true;
            DateTime CreationDate = DateTime.Now;
            Email CreationUser = new Email(addSpecialistCommand.CreationUser);
            DateTime ModificationDate = DateTime.MinValue;
            Email ModificationUser = new Email(null);
            //SpecialistAdder specialistAdder = new SpecialistAdder(_MedicalCenterRepository);
            //specialistAdder.Add(MedicalCenterSpecialistGuid, SpecialistGuid,MedicalCenterGuid,Active,CreationDate,CreationUser,ModificationDate,ModificationUser);
        }
    }
}
