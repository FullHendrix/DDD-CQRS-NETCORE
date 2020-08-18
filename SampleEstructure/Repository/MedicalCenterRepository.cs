using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SampleEstructure.Repository
{
    public interface MedicalCenterRepository 
    {
        void Create(MedicalCenter medicalCenter);
        void AddSpecialist(MedicalCenterSpecialist medicalCenterSpecialist);
        
        Task CreateAsync(MedicalCenter medicalCenter);
        Task AddSpecialistAsync(MedicalCenterSpecialist medicalCenterSpecialist);
        void AddOrUpdateSpecialist(List<MedicalCenterSpecialist> medicalCenterSpecialist);
        Task AddOrUpdateSpecialistAsync(List<MedicalCenterSpecialist> medicalCenterSpecialist);
        bool Exists(GuidValueObject medicalCenterGuid);
        Task<bool> ExistsAsync(GuidValueObject medicalCenterGuid);
        MedicalCenter Read(GuidValueObject medicalCenterGuid);
        Task<MedicalCenter> ReadAsync(GuidValueObject medicalCenterGuid);
        List<MedicalCenter> ReadAll(GuidValueObject CompanyGuid);
        Task<List<MedicalCenter>> ReadAllAsync(GuidValueObject CompanyGuid);
    }
}