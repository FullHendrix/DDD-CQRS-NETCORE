using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterSpecialistConfiguration : IEntityTypeConfiguration<MedicalCenterSpecialist>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSpecialist> builder)
        {
            builder.ToTable("MedicalCenterSpecialists_").HasKey(nameof(MedicalCenterSpecialist.MedicalCenterSpecialistGuid));
            builder.Property(x => x.MedicalCenterSpecialistGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialist.MedicalCenterSpecialistGuid));
            builder.Property(x => x.SpecialistGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialist.SpecialistGuid));
            builder.Property(x => x.MedicalCenterGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialist.MedicalCenterGuid));
            builder.Property(x => x.Active).HasColumnName(nameof(MedicalCenterSpecialist.Active));
            builder.HasOne<MedicalCenter>(x => x.MedicalCenter).WithMany(p => p.MedicalCenterSpecialists).HasForeignKey(x => x.MedicalCenterGuid);
       }
    }
}