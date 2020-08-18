using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Consumedic.Test.MockRepository
{
    public class MedicalCenterFakeReporsitory : GeneralRepository<MedicalCenter>
    {
        public void Create(MedicalCenter DomainEntity)
        {
            
        }
        public Task CreateAsync(MedicalCenter DomainEntity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }

        public MedicalCenter Read(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }

        public List<MedicalCenter> ReadAll(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<List<MedicalCenter>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<MedicalCenter> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }
    }
}