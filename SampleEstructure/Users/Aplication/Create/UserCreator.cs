using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Shared.Domain.ValueObject;
using SampleEstructure.Users.Domain;
using System;
namespace SampleEstructure.Users.Aplication.Create
{
    public class UserCreator
    {
        private GeneralRepository<User> _UserRepository;
        private GeneralRepository<Company> _CompannyRepository;
        public UserCreator(GeneralRepository<User> UserRepository, GeneralRepository<Company> CompannyRepository)
        {
            _UserRepository = UserRepository;
            _CompannyRepository = CompannyRepository;
        }
        #region Guard
        private void ValidateCreateUser(GuidValueObject UserGuid, GuidValueObject CompanyGuid)
        {
            if (_UserRepository.Exists(UserGuid)) throw new Exception("User exists");
            if (!_CompannyRepository.Exists(CompanyGuid)) throw new Exception("Company don't exists");
        }
        #endregion
        public void Create(GuidValueObject UserGuid, StringValueObject Names, StringValueObject LastNames, Email Email, GuidValueObject ProfileGuid, Password Password, bool IsPacient, GuidValueObject ComnpanyGuid, Email UserCreator)
        {
            ValidateCreateUser(UserGuid, ComnpanyGuid);
            User user = User.Create(UserGuid, Names, LastNames, Email, ProfileGuid, Password, IsPacient, ComnpanyGuid, UserCreator);
            _UserRepository.Create(user);
            //Publica eventos de dominio
            //do something
        }
    }
}     