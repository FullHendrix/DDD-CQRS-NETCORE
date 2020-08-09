using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SampleEstructure.Repository
{
    //THIS CLASS BELONGS TO THE DOMAIN LAYER BUT IS HERE FOR THE REPOSITORY LAYER
    public interface GeneralRepository<t>
    {
        void Create(t DomainEntity);
        Task CreateAsync(t DomainEntity);
        bool Exists(GuidValueObject DomainEntityGuid);
        Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid);
        t Read(GuidValueObject DomainEntityGuid);
        Task<t> ReadAsync(GuidValueObject DomainEntityGuid);
        List<t> ReadAll(GuidValueObject CompanyGuid);
        Task<List<t>> ReadAllAsync(GuidValueObject CompanyGuid);
    }
}