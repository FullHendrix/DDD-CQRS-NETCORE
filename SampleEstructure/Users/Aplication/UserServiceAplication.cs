using SampleEstructure.Profile.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Users.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SampleEstructure.Users.Aplication
{
    class UserServiceAplication
    {
        GeneralRepository<Domain.User> _Repository;
        ProfileServiceDomain _ProfileServiceDomain;
        public UserServiceAplication(GeneralRepository<Domain.User> Repository)
        {
            _Repository = Repository;
            //_ProfileServiceDomain = new ProfileServiceDomain();
        }
      
        #region Sincrono
        public void Create(Domain.User User)
        {
            ValidateCreateUser(User.UserGuid);
            //if (User.ProfileGuid == null) User.ProfileGuid = ProfileServiceDomain.GetProfilePacient(User.CompanyGuid);
            ////Procesos
            //User.ProfileGuid = _ProfileGuid;
            _Repository.Create(User);
        }
        #endregion
        #region Asincrono
        public async Task CreateAsync(Domain.User User)
        {
            Guid _ProfileGuid = User.ProfileGuid;
            //Guards
            if (_Repository.Exists(User.UserGuid)) throw new Exception("User exists");
            if (_ProfileGuid.Equals(null)) _ProfileGuid = ProfileServiceDomain.GetProfilePacient(User.CompanyGuid);
            //Procesos
            User.ProfileGuid = _ProfileGuid;
            await _Repository.CreateAsync(User);
        }
        #endregion
    }
}
