using Microsoft.EntityFrameworkCore;
using SampleEstructure.Companies.Domain;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository.Implementation.MSSQL.Configuration;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    public class ConsuMedicDBContex : DbContext
    {
        public ConsuMedicDBContex(DbContextOptions<ConsuMedicDBContex> options ):base(options){}
        public DbSet<Company> Company { get; set; }
        public DbSet<MedicalCenter>  MedicalCenter { get; set; }
        public DbSet<MedicalCenterSpecialist> MedicalCenterSpecialist { get; set; }
        public DbSet<MedicalCenterSpeciality> MedicalCenterSpeciality { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration( new MedicalCenterConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalCenterSpecialistConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalCenterSpecialityConfiguration());
        }
    }
}