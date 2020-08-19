using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEstructure.MedicalCenters.Aplication.Read
{
    public class ReadMedicalCenterHandler
    {
        MedicalCenterRepository _medicalCenterRepository;
        public ReadMedicalCenterHandler(MedicalCenterRepository medicalCenterRepository)
        {
            _medicalCenterRepository = medicalCenterRepository;
        }
        public void Handle( ReadMedicalCenterQuery readMedicalCenterQuery )
        {
            GuidValueObject MedicalCenterGuid = new GuidValueObject(readMedicalCenterQuery.MedicalCenterGuid);
            _medicalCenterRepository.Read(MedicalCenterGuid);
        }
    }
}
