using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using SampleEstructure.Users.Domain;
using System;
using System.Threading.Tasks;
namespace SampleEstructure.Users.Aplication
{
    class UserServiceAplication
    {
        GeneralRepository<User> _Repository;
        //ProfileServiceDomain _ProfileServiceDomain;
        public UserServiceAplication(GeneralRepository<Domain.User> Repository)
        {
            _Repository = Repository;
            //_ProfileServiceDomain = new ProfileServiceDomain();
        }
      
        #region Sincrono
        public void Create(User User)
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
            ValidateCreateUser(User.UserGuid);
            //if (_ProfileGuid.Equals(null)) _ProfileGuid = ProfileServiceDomain.GetProfilePacient(User.CompanyGuid);
            //Procesos
            //User.ProfileGuid = _ProfileGuid;
            await _Repository.CreateAsync(User);
        }
        #endregion
        private void ValidateCreateUser(GuidValueObject userGuid)
        {
            if (_Repository.Exists(userGuid)) throw new Exception("User doesn't exists");
        }
    }
}
