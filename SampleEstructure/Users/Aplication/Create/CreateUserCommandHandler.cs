using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Users.Aplication.Create
{
    public class CreateUserCommandHandler
    {
        private readonly UserCreator _userCreator;
        public CreateUserCommandHandler(UserCreator userCreator)
        {
            _userCreator = userCreator;
        }
        public void Handle(CreateUserCommand Command)
        {
            //Asignamos los valores primitivos del comando hacia los valueobjects
            GuidValueObject UserGuid = new GuidValueObject(Guid.NewGuid().ToString());
            StringValueObject Names = new StringValueObject(Command.Names);
            StringValueObject LastNames = new StringValueObject(Command.LastNames);
            Email Email = new Email(Command.Email);
            GuidValueObject ProfileGuid = new GuidValueObject(Command.ProfileGuid);
            Password Password = new Password(Command.Password) ;
            bool IsPacient = Command.IsPacient;
            GuidValueObject CompanyGuid = new GuidValueObject(Command.CompanyGuid);
            Email UserCreator = new Email(Command.CurrentUser);
            _userCreator.Create(UserGuid, Names ,LastNames,Email, ProfileGuid, Password ,IsPacient, CompanyGuid, UserCreator);
        }
    }
}