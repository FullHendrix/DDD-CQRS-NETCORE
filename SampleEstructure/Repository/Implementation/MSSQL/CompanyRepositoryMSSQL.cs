using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SampleEstructure.Companies.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    class CompanyRepositoryMSSQL : GeneralRepository<Company>
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public CompanyRepositoryMSSQL(ConsuMedicDBContex ConsuMedicDBContex)
        {
            _ConsuMedicDBContex = ConsuMedicDBContex;
        }

        public void Create(Company DomainEntity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Company DomainEntity)
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

        public Company Read(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }

        public List<Company> ReadAll(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Company>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Company> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            throw new NotImplementedException();
        }
        //public void Create(Company DomainEntity)
        //{
        //    _ConsuMedicDBContex.Company.Add(DomainEntity);
        //    _ConsuMedicDBContex.SaveChanges();
        //}
        //public async Task CreateAsync(Company DomainEntity)
        //{
        //    _ConsuMedicDBContex.Company.Add(DomainEntity);
        //    await _ConsuMedicDBContex.SaveChangesAsync();
        //}
        //public bool Exists(GuidValueObject DomainEntityGuid)
        //{
        //    return _ConsuMedicDBContex.Company.Any(x => x.CompanyGuid.Equals(DomainEntityGuid));
        //}
        //public async Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid)
        //{
        //    return await _ConsuMedicDBContex.Company.AnyAsync(x => x.CompanyGuid.Equals(DomainEntityGuid));
        //}
        //public Company Read(GuidValueObject DomainEntityGuid)
        //{
        //    return _ConsuMedicDBContex.Company.SingleOrDefault(x => x.CompanyGuid.Equals(DomainEntityGuid));
        //}
        //public List<Company> ReadAll(GuidValueObject CompanyGuid)
        //{
        //    return _ConsuMedicDBContex.Company.ToList();
        //}
        //public async Task<List<Company>> ReadAllAsync(GuidValueObject CompanyGuid)
        //{
        //    return await _ConsuMedicDBContex.Company.ToListAsync();
        //}
        //public async Task<Company> ReadAsync(GuidValueObject DomainEntityGuid)
        //{
        //    return await _ConsuMedicDBContex.Company.SingleOrDefaultAsync(x => x.CompanyGuid.Equals(DomainEntityGuid));
        //}
    }
}