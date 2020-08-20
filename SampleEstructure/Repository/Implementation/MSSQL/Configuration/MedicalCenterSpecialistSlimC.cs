using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Shared.Domain;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterSpecialistSlimC : IEntityTypeConfiguration<MedicalCenterSpecialistSlim>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSpecialistSlim> builder)
        {
            builder.ToTable("MedicalCenterSpecialists").HasKey(x => x.MedicalCenterSpecialistGuid);
            builder.HasOne<MedicalCenterSlim>(s => s.MedicalCenter).WithMany(x => x.MedicalCenterSpecialists).HasForeignKey(s => s.MedicalCenterGuid);
        }
    }
}
