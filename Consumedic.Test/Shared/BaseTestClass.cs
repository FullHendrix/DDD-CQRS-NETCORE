using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Repository;
using SampleEstructure.Repository.Implementation.MSSQL;
using System;

namespace Consumedic.Test.Shared
{
    public class BaseTestClass
    {
        //public GeneralRepository<MedicalCenter> MedicalCenterRepository { get; private set; }
        public MedicalCenterRepository MedicalCenterRepository { get; set; }
        public string CentrealMedicalGuid { get; set; }
      
    }
}