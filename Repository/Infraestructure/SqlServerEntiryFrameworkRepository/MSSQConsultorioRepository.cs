using Domain.Repository;
using Repository.Domain.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace Repository.Infraestructure.SqlServerEntiryFrameworkRepository
{
    public class MSSQConsultorioRepository : GeneralRepository<Consultorio>
    {
        CitaMedicaContext _citaMedicaContext;
        
        public MSSQConsultorioRepository( CitaMedicaContext citaMedicaContext)
        {
            _citaMedicaContext = citaMedicaContext;
        }
        public Consultorio Create(Consultorio obj)
        {
            _citaMedicaContext.Consultorio.Add(obj);
            _citaMedicaContext.SaveChanges();
            return obj;
        }

        public Task<Consultorio> CreateAsync(Consultorio obj)
        {
            throw new NotImplementedException();
        }

        public Consultorio Delete(Consultorio obj)
        {
            throw new NotImplementedException();
        }

        public Task<Consultorio> DeleteAsync(Consultorio obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consultorio> Read(Consultorio obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Consultorio>> ReadAsync(Consultorio obj)
        {
            throw new NotImplementedException();
        }

        public Consultorio Update(Consultorio obj)
        {
            throw new NotImplementedException();
        }

        public Task<Consultorio> UpdateAsync(Consultorio obj)
        {
            throw new NotImplementedException();
        }
    }
}