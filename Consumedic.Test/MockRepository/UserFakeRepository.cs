using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using SampleEstructure.Users.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ConsoleTest.MockRepository
{
    class UserFakeRepository : GeneralRepository<User>
    {
        public void Create(User DomainEntity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(User DomainEntity)
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

        public User Read(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadAll(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<User> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }
    }
}
