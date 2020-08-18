using Consumedic.Test.MockRepository;
using Consumedic.Test.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.MedicalCenters.Aplication.Create;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using System;

namespace Consumedic.Test.MedicalCenters
{
    [TestClass]
    public class Create : BaseTestClass
    {
       [TestMethod]
        public void CreateMedicalCenterValid()
        {
            Initialize();
            CreateMedicalCenterCommand createMedicalCenterCommand = CreateMedicalCenterCommand.Create(Guid.NewGuid().ToString(), "CONSUMEDIC Villa el Salvador", 1, "Mz N Lt 13 Gr 27 Sc 3 Villa el Salvador", "Roberto Gomez", 
            "60355a31-f465-4e7c-b903-1e9654e8d1fb", "cespejo25@gmail.com");
            CreateMedicalCenterHandler createMedicalCenterHandler = new CreateMedicalCenterHandler(this.MedicalCenterRepository);
            createMedicalCenterHandler.Handle(createMedicalCenterCommand);
        }
    }
}