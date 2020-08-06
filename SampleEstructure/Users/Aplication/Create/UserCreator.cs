using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using SampleEstructure.Users.Domain;
using System;
namespace SampleEstructure.Users.Aplication.Create
{
    public class UserCreator
    {
        GeneralRepository<User> _UserRepository;
        GeneralRepository<Company> _CompannyRepository;
        UserCreator(GeneralRepository<User> UserRepository, GeneralRepository<Company> CompannyRepository)
        {
            _UserRepository = UserRepository;
            _CompannyRepository = CompannyRepository;
        }
        #region Guard
        private void ValidateCreateUser(Guid UserGuid, Guid CompanyGuid)
        {
            if (_UserRepository.Exists(UserGuid)) throw new Exception("User exists");
            if (!_CompannyRepository.Exists(CompanyGuid)) throw new Exception("Company don't exists");
        }
        #endregion
        public void Create(Guid UserGuid, string Names, string LastNames, Email Email, Guid ProfileGuid, Password Password, bool IsPacient, Guid ComnpanyGuid)
        {
            ValidateCreateUser(UserGuid, ComnpanyGuid);
            User user = User.Create(UserGuid, Names, LastNames, Email, ProfileGuid, Password, IsPacient, ComnpanyGuid);
            _UserRepository.Create(user);
            //Publica eventos de dominio
            //do something
        }
    }
}