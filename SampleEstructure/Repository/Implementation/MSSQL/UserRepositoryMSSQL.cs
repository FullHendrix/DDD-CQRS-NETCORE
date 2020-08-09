using Microsoft.EntityFrameworkCore;
using SampleEstructure.Shared.Domain.ValueObject;
using SampleEstructure.Users.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class MSSQLUserRepository : GeneralRepository<User>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public MSSQLUserRepository(ConsuMedicDBContex consuMedicDBContex)
        {
            _ConsuMedicDBContex = consuMedicDBContex;
        }
        public void Create(User DomainEntity)
        {
            _ConsuMedicDBContex.User.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task CreateAsync(User DomainEntity)
        {
            _ConsuMedicDBContex.User.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public User Read(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.User.SingleOrDefault(x => x.UserGuid.Equals(DomainEntityGuid));
        }
        public async Task<User> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.User.SingleOrDefaultAsync(x => x.UserGuid.Equals(DomainEntityGuid));
        }
        public List<User> ReadAll(GuidValueObject CompanyGuid)
        {
            return _ConsuMedicDBContex.User.Where(x => x.CompanyGuid == CompanyGuid).ToList();
        }
        public async Task<List<User>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            return await _ConsuMedicDBContex.User.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToListAsync();
        }
        public bool Exists(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.User.Any(x => x.UserGuid == DomainEntityGuid);
        }
        public async Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.User.AnyAsync(x => x.UserGuid.Equals(DomainEntityGuid));
        }
    }
}