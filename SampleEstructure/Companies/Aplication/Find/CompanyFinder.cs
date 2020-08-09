using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Companies.Aplication.Find
{
    class CompanyFinder
    {
        GeneralRepository<Company> _Repository;
        public CompanyFinder(GeneralRepository<Company> Repository)
        {
            _Repository = Repository;
        }
        public Company Find(GuidValueObject CompanyGuid )
        {
            return _Repository.Read(CompanyGuid);
        }
    }
}