using ConsoleTest.MockRepository;
using Consumedic.Test.MockRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Users.Aplication.Create;
using SampleEstructure.Users.Domain;
using System;
namespace Consumedic.Test.UserTest
{
    [TestClass]
    class UserAplicationTest
    {
        [TestMethod]
        public void CreateUserCommandHandlerTest(CreateUserCommand comnmand)
        {
            GeneralRepository<User> userReposritory = new UserFakeRepository();
            GeneralRepository<Company> companyReposritory = new CompanyFakeRepository();

            string userGuid = Guid.NewGuid().ToString();
            string names = "Carlos Rufino";
            string lastnames = "Espejo Huerta";
            string email = "cespejo25@gmail.com";
            string profileGuid =Guid.NewGuid().ToString();
            string password = "2875849";
            bool isPacient = false;
            string companyGuid = Guid.NewGuid().ToString();
            string CurrentUser = "cespejo25@gmail.com";
            CreateUserCommand createUserCommand = new CreateUserCommand(userGuid, names, lastnames, email, profileGuid, password, isPacient, companyGuid, CurrentUser);
            UserCreator userCreator = new UserCreator(userReposritory, companyReposritory);
            CreateUserCommandHandler createUserCommandHandler = new CreateUserCommandHandler(userCreator);
        }
    }
}