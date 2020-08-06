using Microsoft.EntityFrameworkCore;
using SampleEstructure.Profile.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class ProfileRepositoryMSSQL : GeneralRepository<ProfileModelDomain>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public ProfileRepositoryMSSQL(ConsuMedicDBContex consuMedicDBContex)
        {
            _ConsuMedicDBContex = consuMedicDBContex;
        }
        public void Create(ProfileModelDomain DomainEntity)
        {
            _ConsuMedicDBContex.Profile.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();

        }
        public async Task CreateAsync(ProfileModelDomain DomainEntity)
        {
            _ConsuMedicDBContex.Profile.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public ProfileModelDomain Read(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.Profile.SingleOrDefault( x => x.ProfileGuid == DomainEntityGuid);
        }
        public async Task<ProfileModelDomain> ReadAsync(Guid DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.Profile.SingleOrDefaultAsync(x => x.ProfileGuid == DomainEntityGuid);
        }
        public List<ProfileModelDomain> ReadAll(Guid CompanyGuid)
        {
            return _ConsuMedicDBContex.Profile.Where(x => x.CompanyGuid == CompanyGuid).ToList();
        }
        public async Task<List<ProfileModelDomain>> ReadAllAsync(Guid CompanyGuid)
        {
            return await _ConsuMedicDBContex.Profile.Where(x => x.CompanyGuid == CompanyGuid).ToListAsync();
        }
        public bool Exists(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.Profile.Any(x => x.ProfileGuid == DomainEntityGuid);
        }
        public async Task<bool> ExistsAsync(Guid DomainEntityGuid)
        {
            return await  _ConsuMedicDBContex.Profile.AnyAsync(x => x.ProfileGuid == DomainEntityGuid);
        }
    }
}