using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Users.Domain
{
    public class User : DomainModel
    {
        public Guid UserGuid { get; private set; }
        public string Names { get; private set; }
        public string LastNames { get; private set; }
        public Email Email { get; private set; }
        public Guid ProfileGuid { get; private set; }
        public Password Password { get; private set; }
        public bool IsPacient { get; private set; }
        public Guid CompanyGuid { get; private set; }
        private User(Guid UserGuid, string Names, string LastNames, Email Email, Guid ProfileGuid, Password Password, bool IsPacient, Guid CompanyGuid, string CreationUser) {
            this.UserGuid = UserGuid;
            this.Names = Names;
            this.LastNames = LastNames;
            this.Email = Email;
            this.ProfileGuid = ProfileGuid;
            this.Password = Password;
            this.IsPacient = IsPacient;
            this.CompanyGuid = CompanyGuid;
            this.CreacionDate = DateTime.Now;
            this.CreacionUser = CreationUser;
        }
        public static User Create(Guid UserGuid, string Names, string LastNames, Email Email, Guid ProfileGuid, Password Password, bool IsPacient, Guid ComanpanyGuid, string CreationUser)
        {
            User user = new User(UserGuid,Names,LastNames,Email,ProfileGuid,Password,IsPacient,ComanpanyGuid,CreationUser);
            //Agrega eventos de dominio
            //do somethin
            return user;
        }
    }
}
