using System;
namespace SampleEstructure.Users.Aplication.Create
{
    public class CreateUserCommand
    {
        public Guid UserGuid { get; private set; }
        public string Names { get; private set; }
        public string LastNames { get; private set; }
        public string Email { get; private set; }
        public Guid ProfileGuid { get; private set; }
        public string Password { get; private set; }
        public bool IsPacient { get; private set; }
        public Guid CompanyGuid { get; private set; }
        public CreateUserCommand(Guid userguid, string names , string lastnames, string email, Guid profileguid, string password, bool ispacient, Guid companyguid  )
        {
            this.UserGuid = userguid;
            this.Names = names;
            this.LastNames = lastnames;
            this.Email = email;
            this.ProfileGuid = profileguid;
            this.Password = password;
            this.IsPacient = ispacient;
            this.CompanyGuid = companyguid;
        }
    }
}