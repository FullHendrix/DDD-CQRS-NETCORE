using Microsoft.EntityFrameworkCore;
using Repository.Domain.DomainEntity;
namespace Repository.Infraestructure.SqlServerEntiryFrameworkRepository
{
    public partial class CitaMedicaContext :DbContext
    {
        public CitaMedicaContext(DbContextOptions<CitaMedicaContext> options) : base(options)
        {
        }
        public virtual DbSet<Consultorio> Consultorio { get; set; }
    }
}