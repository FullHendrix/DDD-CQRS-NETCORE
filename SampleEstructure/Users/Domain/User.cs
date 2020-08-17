using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Users.Domain
{
    public class User : DomainModel
    {
        public GuidValueObject UserGuid { get; private set; }
        public StringValueObject Names { get; private set; }
        public StringValueObject LastNames { get; private set; }
        public Email Email { get; private set; }
        public GuidValueObject ProfileGuid { get; private set; }
        public Password Password { get; private set; }
        public bool IsPacient { get; private set; }
        public GuidValueObject CompanyGuid { get; private set; }
        private User(GuidValueObject UserGuid, StringValueObject Names, StringValueObject LastNames, Email Email, GuidValueObject ProfileGuid, Password Password, bool IsPacient, GuidValueObject CompanyGuid, Email CreationUser) {
            this.UserGuid = UserGuid;
            this.Names = Names;
            this.LastNames = LastNames;
            this.Email = Email;
            this.ProfileGuid = ProfileGuid;
            this.Password = Password;
            this.IsPacient = IsPacient;
            this.CompanyGuid = CompanyGuid;
            this.CreationDate = DateTime.Now;
            this.CreationUser = CreationUser;
        }
        public static User Create(GuidValueObject UserGuid, StringValueObject Names, StringValueObject LastNames, Email Email, GuidValueObject ProfileGuid, Password Password, bool IsPacient, GuidValueObject CompanyGuid, Email CreationUser)
        {
            User user = new User(UserGuid,Names,LastNames,Email,ProfileGuid,Password,IsPacient,CompanyGuid,CreationUser);
            //Agrega eventos de dominio
            //do somethin
            return user;
        }
    }
}