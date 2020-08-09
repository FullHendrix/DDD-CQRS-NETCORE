using ConsoleTest.MockRepository;
using Consumedic.Test.MockRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.Companies.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Users.Aplication.Create;
using SampleEstructure.Users.Domain;

namespace Consumedic.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateUserCommandHandler()
        {
            GeneralRepository<User> userRepository = new UserFakeRepository();
            GeneralRepository<Company> companyRepository = new CompanyFakeRepository();
            UserCreator userCreator = new UserCreator(userRepository, companyRepository);

            CreateUserCommandHandler commandHandler = new CreateUserCommandHandler(userCreator);
            commandHandler.Handle(new CreateUserCommand("", "", "", "", "", "", true, "", ""));
            Assert.IsTrue(true);
        }
    }
}
