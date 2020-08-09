using Microsoft.EntityFrameworkCore;
using SampleEstructure.OptionMenuProfiles.Domain;
using SampleEstructure.Profiles.Domain;
using SampleEstructure.Users.Domain;
using SampleEstructure.Companies.Domain;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    public class ConsuMedicDBContex : DbContext
    {
        public ConsuMedicDBContex(DbContextOptions<ConsuMedicDBContex> options ):base(options){}
        public DbSet<User> User { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<OptionMenuProfile> OptionMenuProfileModelDomain { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}