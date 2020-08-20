using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Shared.Domain;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterSlimC : IEntityTypeConfiguration<MedicalCenterSlim>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSlim> builder)
        {
            builder.ToTable("MedicalCenters").HasKey(x => x.MedicalCenterGuid);
        }
    }
}