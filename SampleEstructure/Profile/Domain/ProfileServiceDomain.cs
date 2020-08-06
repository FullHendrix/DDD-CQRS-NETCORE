using SampleEstructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleEstructure.Profile.Domain
{
    class ProfileServiceDomain
    {
        GeneralRepository<ProfileModelDomain> _Repository;
        public ProfileServiceDomain(GeneralRepository<ProfileModelDomain> Repository)
        {
            _Repository = Repository;
        }
        public Guid GetProfilePacient(Guid CompanyGuid)
        {
            return _Repository.ReadAll(CompanyGuid).SingleOrDefault(x => x.IsPacient == true).ProfileGuid;
        }
        public void CreateUserProfile(Guid UserGuid)
        {
            
        }
    }
}
