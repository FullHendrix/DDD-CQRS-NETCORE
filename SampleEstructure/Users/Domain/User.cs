using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Users.Domain
{
    public class User
    {
        public Guid UserGuid { get; set; }
        public string Names { get; set; }
        public string LastNames { get; set; }
        public Email Email { get; set; }
        public Guid ProfileGuid { get; set; }
        public Password Password { get; set; }
        public bool IsPacient { get; set; }
        public Guid CompanyGuid { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid CreationUserGuid { get; set; }
        public DateTime? ModificationDate { get; set; }
        public Guid? ModificationUserGuid { get; set; }
        public User(Guid UserGuid, string Names, string LastNames, Email Email, Guid ProfileGuid, Password Password , bool IsPacient,  Guid ComanpanyGuid,  )
        {

        }
        public static User Create()
        {
            User user = new User();
            return user;
        }
    }
}