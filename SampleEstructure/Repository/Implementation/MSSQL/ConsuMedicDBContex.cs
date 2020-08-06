using Microsoft.EntityFrameworkCore;
using SampleEstructure.OptionMenuProfile.Domain;
using SampleEstructure.Profile.Domain;
using SampleEstructure.Users.Domain;
using SampleEstructure.Companies.Domain;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    public class ConsuMedicDBContex : DbContext
    {
        public ConsuMedicDBContex(DbContextOptions<ConsuMedicDBContex> options ):base(options){}
        public DbSet<User> User { get; set; }
        public DbSet<ProfileModelDomain> Profile { get; set; }
        public DbSet<OptionMenuProfileModelDomain> OptionMenuProfileModelDomain { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}