using Microsoft.EntityFrameworkCore;
using SampleEstructure.User.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class MSSQLUserRepository : GeneralRepository<User.Domain.User>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public MSSQLUserRepository(ConsuMedicDBContex consuMedicDBContex)
        {
            _ConsuMedicDBContex = consuMedicDBContex;
        }
        public void Create(User.Domain.User DomainEntity)
        {
            _ConsuMedicDBContex.User.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task CreateAsync(User.Domain.User DomainEntity)
        {
            _ConsuMedicDBContex.User.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public User.Domain.User Read(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.User.SingleOrDefault(x => x.UserGuid == DomainEntityGuid);
        }
        public async Task<User.Domain.User> ReadAsync(Guid DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.User.SingleOrDefaultAsync(x => x.UserGuid == DomainEntityGuid);
        }
        public List<User.Domain.User> ReadAll(Guid CompanyGuid)
        {
            return _ConsuMedicDBContex.User.Where(x => x.CompanyGuid == CompanyGuid).ToList();
        }
        public async Task<List<User.Domain.User>> ReadAllAsync(Guid CompanyGuid)
        {
            return await _ConsuMedicDBContex.User.Where(x => x.CompanyGuid == CompanyGuid).ToListAsync();
        }
        public bool Exists(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.User.Any(x => x.UserGuid == DomainEntityGuid);
        }
        public async Task<bool> ExistsAsync(Guid DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.User.AnyAsync(x => x.UserGuid == DomainEntityGuid);
        }
    }
}