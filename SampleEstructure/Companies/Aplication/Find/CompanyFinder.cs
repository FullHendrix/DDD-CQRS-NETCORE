using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;
namespace SampleEstructure.Companies.Aplication.Find
{
    class CompanyFinder
    {
        GeneralRepository<Company> _Repository;
        public CompanyFinder(GeneralRepository<Company> Repository)
        {
            _Repository = Repository;
        }
        public Company Find(Guid CompanyGuid )
        {
            return _Repository.Read(CompanyGuid);
        }
    }
}