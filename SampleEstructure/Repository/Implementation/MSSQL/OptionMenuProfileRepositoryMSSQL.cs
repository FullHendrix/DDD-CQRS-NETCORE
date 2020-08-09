using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SampleEstructure.OptionMenuProfiles.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class OptionMenuProfileRepositoryMSSQL : GeneralRepository<OptionMenuProfile>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public OptionMenuProfileRepositoryMSSQL(ConsuMedicDBContex ConsuMedicDBContex)
        {
            _ConsuMedicDBContex = ConsuMedicDBContex;
        }
        public void Create(OptionMenuProfile DomainEntity)
        {
            _ConsuMedicDBContex.OptionMenuProfileModelDomain.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task CreateAsync(OptionMenuProfile DomainEntity)
        {
            _ConsuMedicDBContex.OptionMenuProfileModelDomain.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public bool Exists(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.OptionMenuProfileModelDomain.Any(x => x.OptionMenuProfileGuid.Equals( DomainEntityGuid)) ;
        }
        public Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.OptionMenuProfileModelDomain.AnyAsync(x => x.OptionMenuProfileGuid.Equals(DomainEntityGuid));
        }
        public OptionMenuProfile Read(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.OptionMenuProfileModelDomain.SingleOrDefault(x => x.OptionMenuProfileGuid.Equals(DomainEntityGuid));
        }
        public async Task<OptionMenuProfile> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.OptionMenuProfileModelDomain.SingleOrDefaultAsync(x => x.OptionMenuProfileGuid.Equals(DomainEntityGuid));
        }
        public  List<OptionMenuProfile> ReadAll(GuidValueObject CompanyGuid)
        {
            return  _ConsuMedicDBContex.OptionMenuProfileModelDomain.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToList();
        }
        public async Task<List<OptionMenuProfile>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            return await _ConsuMedicDBContex.OptionMenuProfileModelDomain.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToListAsync();
        }
    }
}