namespace SampleEstructure.Users.Aplication.Create
{
    public class CreateUserCommand
    {
        public string UserGuid { get; private set; }
        public string Names { get; private set; }
        public string LastNames { get; private set; }
        public string Email { get; private set; }
        public string ProfileGuid { get; private set; }
        public string Password { get; private set; }
        public bool IsPacient { get; private set; }
        public string CompanyGuid { get; private set; }
        public string CurrentUser { get; set; }
        public CreateUserCommand(string userguid, string names , string lastnames, string email, string profileguid, string password, bool ispacient, string companyguid, string CurrentUser  )
        {
            this.UserGuid = userguid;
            this.Names = names;
            this.LastNames = lastnames;
            this.Email = email;
            this.ProfileGuid = profileguid;
            this.Password = password;
            this.IsPacient = ispacient;
            this.CompanyGuid = companyguid;
            this.CurrentUser = CurrentUser;
        }
    }
}