using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Consumedic.Test.MockRepository
{
    class CompanyFakeRepository : GeneralRepository<Company>
    {
        public void Create(Company DomainEntity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Company DomainEntity)
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

        public Company Read(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }

        public List<Company> ReadAll(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Company> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }
    }
}