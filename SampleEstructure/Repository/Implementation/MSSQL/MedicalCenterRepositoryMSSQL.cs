using Microsoft.EntityFrameworkCore;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
using System;
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
            ////Blog----
            //var blog = Blog.Create(3, "asdasd");
            //blog.AddPost(7, "Intro to C#");
            //blog.AddPost(8, "Intro to VB.NET
            //);
            //blog.AddPost(9, "Intro to F#");1            //_ConsuMedicDBContex.Blogs.Add(blog)            //_ConsuMedicDBContex.SaveChanges();
            ////Listar Blog
            //var rblog = _ConsuMedicDBContex.Blogs.Include("Posts").FirstOrDefault(x => x.IdBlog == blog.IdBlog);
            //var d = rblog.Posts;
            //MedicalCenterSlim----
            var MCS = MedicalCenterSlim.Create(Guid.NewGuid(), "Prueba", 1, "Calle", "Uno", Guid.NewGuid());
            MCS.AddMedicalCenterSpecialists(Guid.NewGuid(), Guid.NewGuid());
            _ConsuMedicDBContex.MedicalCenterS.Add(MCS);
            _ConsuMedicDBContex.SaveChanges();

            var MCSR = _ConsuMedicDBContex.MedicalCenterS.Include("MedicalCenterSpecialists").FirstOrDefault(x => x.MedicalCenterGuid.Equals(MCS.MedicalCenterGuid));
            var mcsrl = MCSR.MedicalCenterSpecialists;
            //MedicalCenter----
            GuidValueObject MedicalCenterSpecialistGuid = new GuidValueObject(Guid.NewGuid().ToString());
            GuidValueObject SpecialistGuid = new GuidValueObject(Guid.NewGuid().ToString());
            DomainEntity.AddSpecialist(MedicalCenterSpecialistGuid, SpecialistGuid);
            _ConsuMedicDBContex.MedicalCenter.Add(DomainEntity);
            _ConsuMedicDBContex.SaveChanges();
            //var rmedicalcenter = _ConsuMedicDBContex.MedicalCenter.Include(b => b.MedicalCenterSpecialists).FirstOrDefault(x => x.MedicalCenterGuid.Equals(DomainEntity.MedicalCenterGuid));
            var rmedicalcenter = _ConsuMedicDBContex.MedicalCenter.Include(b => b.MedicalCenterSpecialists).First();
            var rmedicalcenterspecialist = rmedicalcenter.MedicalCenterSpecialists;
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
            var medicalCenter = _ConsuMedicDBContex.MedicalCenter.SingleOrDefault(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));
            var a = medicalCenter.MedicalCenterSpecialists;
            var medicalCenter2 = _ConsuMedicDBContex.MedicalCenter.Include("MedicalCenterSpecialist").SingleOrDefault(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));
            //List<MedicalCenterSpecialist> c = new List<MedicalCenterSpecialist>();
            //c = _ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToList();
            //medicalCenter.SetmedicalCenterSpecialists(_ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToList());
            //medicalCenter.SetmedicalCenterSpecialities(_ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToList());
            return medicalCenter;
        }
        public List<MedicalCenter> ReadAll(GuidValueObject CompanyGuid)
        {
            var medicalCenters = _ConsuMedicDBContex.MedicalCenter.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToList();
            //foreach(MedicalCenter medicalCenter in medicalCenters)
            //{
            //    medicalCenter.SetmedicalCenterSpecialists(_ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToList());
            //    medicalCenter.SetmedicalCenterSpecialities(_ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToList());
            //}
            return medicalCenters;
        }
        public async Task<List<MedicalCenter>> ReadAllAsync(GuidValueObject CompanyGuid)
        {
            var medicalCenters = _ConsuMedicDBContex.MedicalCenter.Where(x => x.CompanyGuid.Equals(CompanyGuid)).ToList();
            //foreach (MedicalCenter medicalCenter in medicalCenters)
            //{
            //    medicalCenter.SetmedicalCenterSpecialists(await _ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToListAsync());
            //    medicalCenter.SetmedicalCenterSpecialities(await _ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(medicalCenter.MedicalCenterGuid)).ToListAsync());
            //}
            return medicalCenters;
        }
        public async Task<MedicalCenter> ReadAsync(GuidValueObject DomainEntityGuid)
        {
            var medicalCenter = _ConsuMedicDBContex.MedicalCenter.SingleOrDefault(x => x.MedicalCenterGuid.Equals(DomainEntityGuid));
            //medicalCenter.SetmedicalCenterSpecialists(await _ConsuMedicDBContex.MedicalCenterSpecialist.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToListAsync());
            //medicalCenter.SetmedicalCenterSpecialities(await _ConsuMedicDBContex.MedicalCenterSpeciality.Where(x => x.MedicalCenterGuid.Equals(DomainEntityGuid)).ToListAsync());
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