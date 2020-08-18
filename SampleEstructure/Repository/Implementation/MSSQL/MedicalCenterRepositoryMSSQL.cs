using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SampleEstructure.Repository.Implementation.MSSQL
{
    public class MedicalCenterRepositoryMSSQL : MedicalCenterRepository
    {
        ConsuMedicDBContex _ConsuMedicDBContex;
        public MedicalCenterRepositoryMSSQL(ConsuMedicDBContex ConsuMedicDBContex)
        {
            _ConsuMedicDBContex = ConsuMedicDBContex;
        }
        public void Create(MedicalCenter DomainEntity)
        {
            _ConsuMedicDBContex.MedicalCenter.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
        }

        public async Task CreateAsync(MedicalCenter DomainEntity)
        {
            _ConsuMedicDBContex.MedicalCenter.Add(DomainEntity);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public bool Exists(GuidValueObject DomainEntityGuid)
        {
            return _ConsuMedicDBContex.MedicalCenter.Any(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));
        }

        public async Task<bool> ExistsAsync(GuidValueObject DomainEntityGuid)
        {
            return await _ConsuMedicDBContex.MedicalCenter.AnyAsync(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));
        }
        public MedicalCenter Read(GuidValueObject DomainEntityGuid)
        {
            var medicalCenter =  _ConsuMedicDBContex.MedicalCenter.SingleOrDefault(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));

            List<MedicalCenterSpecialist> c = new List<MedicalCenterSpecialist>();
                c = _ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToList();

            medicalCenter.SetmedicalCenterSpecialists(_ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToList());
            medicalCenter.SetmedicalCenterSpecialities(_ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToList());
            return medicalCenter;
        }
        public List<MedicalCenter> ReadAll(GuidValueObject CompanyGuid)
        {
            var medicalCenters = _ConsuMedicDBContex.MedicalCenter.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToList();
            foreach(MedicalCenter medicalCenter in medicalCenters)
            {
                medicalCenter.SetmedicalCenterSpecialists(_ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToList());
                medicalCenter.SetmedicalCenterSpecialities(_ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToList());
            }
            return medicalCenters;
        }
        public async Task<List<MedicalCenter>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            var medicalCenters = _ConsuMedicDBContex.MedicalCenter.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToList();
            foreach (MedicalCenter medicalCenter in medicalCenters)
            {
                medicalCenter.SetmedicalCenterSpecialists(await _ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToListAsync());
                medicalCenter.SetmedicalCenterSpecialities(await _ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToListAsync());
            }
            return medicalCenters;
        }
        public async Task<MedicalCenter> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            var medicalCenter = _ConsuMedicDBContex.MedicalCenter.SingleOrDefault(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));
            medicalCenter.SetmedicalCenterSpecialists(await _ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToListAsync());
            medicalCenter.SetmedicalCenterSpecialities(await _ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToListAsync());
            return medicalCenter;
        }
        public void AddSpecialist(MedicalCenterSpecialist medicalCenterSpecialist)
        {
            _ConsuMedicDBContex.MedicalCenterSpecialist.Add(medicalCenterSpecialist);
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task AddSpecialistAsync(MedicalCenterSpecialist medicalCenterSpecialist)
        {
            _ConsuMedicDBContex.MedicalCenterSpecialist.Add(medicalCenterSpecialist);
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
        public void AddOrUpdateSpecialist(List<MedicalCenterSpecialist> medicalCenterSpecialist)
        {
            foreach (var data in medicalCenterSpecialist)
            {
                var exists = _ConsuMedicDBContex.MedicalCenterSpecialist.Any(x => x.MedicalCenterSpecialistGuid == data.MedicalCenterSpecialistGuid);
                if (exists)
                {
                    _ConsuMedicDBContex.MedicalCenterSpecialist.Update(data);
                    continue;
                }
                _ConsuMedicDBContex.MedicalCenterSpecialist.Add(data);
            }
            _ConsuMedicDBContex.SaveChanges();
        }
        public async Task AddOrUpdateSpecialistAsync(List<MedicalCenterSpecialist> medicalCenterSpecialist)
        {
            foreach (var data in medicalCenterSpecialist)
            {
                var exists = _ConsuMedicDBContex.MedicalCenterSpecialist.Any(x => x.MedicalCenterSpecialistGuid == data.MedicalCenterSpecialistGuid);
                if (exists)
                {
                    _ConsuMedicDBContex.MedicalCenterSpecialist.Update(data);
                    continue;
                }
                _ConsuMedicDBContex.MedicalCenterSpecialist.Add(data);
            }
            await _ConsuMedicDBContex.SaveChangesAsync();
        }
    }
}