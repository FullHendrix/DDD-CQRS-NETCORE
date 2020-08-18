using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
namespace SampleEstructure.MedicalCenters.Aplication.AddSpecialist
{
    public class SpecialistAdder
    {
        MedicalCenterRepository _medicalCenterRepository;
        public SpecialistAdder(MedicalCenterRepository medicalCenterRepository)
        {
            _medicalCenterRepository = medicalCenterRepository;
        }
        public void Add(GuidValueObject MedicalCenterSpecialistGuid, GuidValueObject SpecialistGuid, GuidValueObject MedicalCenterGuid,bool Active, DateTime? CreationDate, Email CreationUser, DateTime? ModificationDate, Email ModificationUser)
        { 
            MedicalCenterSpecialist medicalCenterSpecialist = MedicalCenterSpecialist.Create(MedicalCenterSpecialistGuid, SpecialistGuid, MedicalCenterGuid, Active, CreationDate, CreationUser, ModificationDate, ModificationUser);
            _medicalCenterRepository.AddSpecialist(medicalCenterSpecialist);
        }
    }
}