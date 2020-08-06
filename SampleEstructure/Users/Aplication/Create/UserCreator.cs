using SampleEstructure.Repository;
using SampleEstructure.Repository.Implementation.MSSQL;
using SampleEstructure.Users.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SampleEstructure.Users.Aplication.Create
{
    public class UserCreator
    {
        GeneralRepository<User> _UserRepository;
        UserCreator(GeneralRepository<User> UserRepository)
        {
            _UserRepository = UserRepository;
        }
        #region Guard
        private void ValidateCreateUser(Guid UserGuid)
        {
            if (_UserRepository.Exists(UserGuid)) throw new Exception("User exists");
        }
        #endregion
        public void Create(User user)
        {
            ValidateCreateUser(user.UserGuid);
            _UserRepository.Create(user);
        }
    }
}