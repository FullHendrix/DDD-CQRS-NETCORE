using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SampleEstructure.OptionMenuProfile.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class OptionMenuProfileRepositoryMSSQL : GeneralRepository<OptionMenuProfileModelDomain>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public OptionMenuProfileRepositoryMSSQL(ConsuMedicDBContex ConsuMedicDBContex)
        {
            _ConsuMedicDBContex = ConsuMedicDBContex;
        }
        public void Create(OptionMenuProfileModelDomain DomainEntity)
        {
            _ConsuMedicDBContex.OptionMenuProfileModelDomain.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task CreateAsync(OptionMenuProfileModelDomain DomainEntity)
        {
            _ConsuMedicDBContex.OptionMenuProfileModelDomain.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public bool Exists(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.OptionMenuProfileModelDomain.Any(x => x.OptionMenuProfileGuid == DomainEntityGuid ) ;
        }
        public Task<bool> ExistsAsync(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.OptionMenuProfileModelDomain.AnyAsync(x => x.OptionMenuProfileGuid == DomainEntityGuid);
        }
        public OptionMenuProfileModelDomain Read(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.OptionMenuProfileModelDomain.SingleOrDefault( x => x.OptionMenuProfileGuid == DomainEntityGuid );
        }
        public async Task<OptionMenuProfileModelDomain> ReadAsync(Guid DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.OptionMenuProfileModelDomain.SingleOrDefaultAsync(x => x.OptionMenuProfileGuid == DomainEntityGuid);
        }
        public  List<OptionMenuProfileModelDomain> ReadAll(Guid CompanyGuid)
        {
            return  _ConsuMedicDBContex.OptionMenuProfileModelDomain.Where(x => x.CompanyGuid == CompanyGuid).ToList();
        }
        public async Task<List<OptionMenuProfileModelDomain>> ReadAllAsync(Guid CompanyGuid)
        {
            return await _ConsuMedicDBContex.OptionMenuProfileModelDomain.Where(x => x.CompanyGuid == CompanyGuid).ToListAsync();
        }
    }
}