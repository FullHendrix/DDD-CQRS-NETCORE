using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Repository.Implementation.MSSQL;
namespace Consumedic.Test.Shared
{
    public class BaseTestClass
    {
        //public GeneralRepository<MedicalCenter> MedicalCenterRepository { get; private set; }
        public MedicalCenterRepository MedicalCenterRepository { get; private set; }

        public void Initialize()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<ConsuMedicDBContex>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CONSUMEDIC"));
            ConsuMedicDBContex consuMedicDBContex = new ConsuMedicDBContex(optionsBuilder.Options);
            this.MedicalCenterRepository = new MedicalCenterRepositoryMSSQL(consuMedicDBContex);
            //this.MedicalCenterRepository = new MedicalCenterFakeReporsitory();
        }
    }
}