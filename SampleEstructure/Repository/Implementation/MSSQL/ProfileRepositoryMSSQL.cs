using Microsoft.EntityFrameworkCore;
using SampleEstructure.Profiles.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class ProfileRepositoryMSSQL : GeneralRepository<Profile>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public ProfileRepositoryMSSQL(ConsuMedicDBContex consuMedicDBContex)
        {
            _ConsuMedicDBContex = consuMedicDBContex;
        }
        public void Create(Profile DomainEntity)
        {
            _ConsuMedicDBContex.Profile.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();

        }
        public async Task CreateAsync(Profile DomainEntity)
        {
            _ConsuMedicDBContex.Profile.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public Profile Read(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.Profile.SingleOrDefault( x => x.ProfileGuid.Equals(DomainEntityGuid));
        }
        public async Task<Profile> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.Profile.SingleOrDefaultAsync(x => x.ProfileGuid.Equals(DomainEntityGuid));
        }
        public List<Profile> ReadAll(GuidValueObject CompanyGuid)
        {
            return _ConsuMedicDBContex.Profile.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToList();
        }
        public async Task<List<Profile>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            return await _ConsuMedicDBContex.Profile.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToListAsync();
        }
        public bool Exists(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.Profile.Any(x => x.ProfileGuid.Equals(DomainEntityGuid));
        }
        public async Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid)
        {
            return await  _ConsuMedicDBContex.Profile.AnyAsync(x => x.ProfileGuid.Equals(DomainEntityGuid));
        }
    }
}