using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Users.Aplication.Create
{
    /// <summary>
    /// Intencion de crear un usuario
    /// </summary>
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
            Email email = new Email(Command.Email);
            Password password = new Password(Command.Password) ;
            _userCreator.Create(Command.UserGuid, Command.Names ,Command.LastNames,email, Command.ProfileGuid, password ,Command.IsPacient, Command.CompanyGuid);
        }
    }
}