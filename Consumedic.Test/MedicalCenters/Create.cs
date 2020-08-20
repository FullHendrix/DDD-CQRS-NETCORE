using Consumedic.Test.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.MedicalCenters.Aplication.AddSpecialist;
using SampleEstructure.MedicalCenters.Aplication.Create;
using SampleEstructure.MedicalCenters.Aplication.Read;
using SampleEstructure.Repository.Implementation.MSSQL;
using System;
namespace Consumedic.Test.MedicalCenters
{
    [TestClass]
    public class Create : BaseTestClass
    {
        public Create()
        {
            this.CentrealMedicalGuid = Guid.NewGuid().ToString();
        }
        [TestInitialize]
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
        [TestMethod]
        public void ACreateCentralMedicaCorrect()
        {
            CreateMedicalCenterCommand createMedicalCenterCommand = CreateMedicalCenterCommand.Create(this.CentrealMedicalGuid, "CONSUMEDIC Villa el Salvador", 1, "Mz N Lt 13 Gr 27 Sc 3 Villa el Salvador", "Roberto Gomez",
            "60355a31-f465-4e7c-b903-1e9654e8d1fb", "cespejo25@gmail.com");
            CreateMedicalCenterHandler createMedicalCenterHandler = new CreateMedicalCenterHandler(this.MedicalCenterRepository);
            createMedicalCenterHandler.Handle(createMedicalCenterCommand);

            //AddMedicalCenterSpecialistCommand addMedicalCenterSpecialistCommand = AddMedicalCenterSpecialistCommand.Create(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), this.CentrealMedicalGuid);
            //AddMedicalCenterSpecialistHandler addMedicalCenterSpecialistHandler = new AddMedicalCenterSpecialistHandler(this.MedicalCenterRepository);
            //addMedicalCenterSpecialistHandler.Handle(addMedicalCenterSpecialistCommand);

            //ReadMedicalCenterQuery readMedicalCenterQuery = ReadMedicalCenterQuery.Create(this.CentrealMedicalGuid);
            //ReadMedicalCenterHandler readMedicalCenterHandler = new ReadMedicalCenterHandler(this.MedicalCenterRepository);
            //readMedicalCenterHandler.Handle(readMedicalCenterQuery);
        }
        //[TestMethod]
        //public void BAddMedicalCenterSpecialistCorrect()
        //{
          
        //}
        //[TestMethod]
        //public void CReadMedicalCenter()
        //{
            
        //}
    }
}