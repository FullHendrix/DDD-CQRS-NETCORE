using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace SampleEstructure.Repository
{
    //THIS CLASS BELONGS TO THE DOMAIN LAYER BUT IS HERE FOR THE REPOSITORY LAYER
    interface GeneralRepository<t>
    {
        void Create(t DomainEntity);
        Task CreateAsync(t DomainEntity);
        bool Exists(Guid DomainEntityGuid);
        Task<bool> ExistsAsync(Guid DomainEntityGuid);
        t Read(Guid DomainEntityGuid);
        Task<t> ReadAsync(Guid DomainEntityGuid);
        List<t> ReadAll(Guid CompanyGuid);
        Task<List<t>> ReadAllAsync(Guid CompanyGuid);
    }
}