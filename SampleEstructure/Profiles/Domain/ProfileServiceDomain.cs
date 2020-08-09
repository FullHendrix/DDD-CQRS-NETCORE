using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
using System.Linq;
namespace SampleEstructure.Profiles.Domain
{
    class ProfileServiceDomain
    {
        GeneralRepository<Profile> _Repository;
        public ProfileServiceDomain(GeneralRepository<Profile> Repository)
        {
            _Repository = Repository;
        }
        public GuidValueObject GetProfilePacient(GuidValueObject CompanyGuid)
        {
            return _Repository.ReadAll(CompanyGuid).SingleOrDefault(x => x.IsPacient == true).ProfileGuid;
        }
    }
}