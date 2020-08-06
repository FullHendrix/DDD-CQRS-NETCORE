using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SampleEstructure.Companies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class ComapanyRepositoryMSSQL : GeneralRepository<Company>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public ComapanyRepositoryMSSQL(ConsuMedicDBContex ConsuMedicDBContex)
        {
            _ConsuMedicDBContex = ConsuMedicDBContex;
        }
        public void Create(Company DomainEntity)
        {
            _ConsuMedicDBContex.Company.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task CreateAsync(Company DomainEntity)
        {
            _ConsuMedicDBContex.Company.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public bool Exists(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.Company.Any(x => x.CompanyGuid == DomainEntityGuid);
        }
        public async Task<bool> ExistsAsync(Guid DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.Company.AnyAsync(x => x.CompanyGuid == DomainEntityGuid);
        }
        public Company Read(Guid DomainEntityGuid)
        {
            return _ConsuMedicDBContex.Company.SingleOrDefault(x => x.CompanyGuid == DomainEntityGuid);
        }
        public List<Company> ReadAll(Guid CompanyGuid)
        {
            return _ConsuMedicDBContex.Company.ToList();
        }
        public async Task<List<Company>> ReadAllAsync(Guid CompanyGuid)
        {
            return await _ConsuMedicDBContex.Company.ToListAsync();
        }
        public async Task<Company> ReadAsync(Guid DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.Company.SingleOrDefaultAsync(x => x.CompanyGuid == DomainEntityGuid);
        }
    }
}