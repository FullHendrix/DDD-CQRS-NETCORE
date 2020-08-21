using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;

namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterSpecialistSlimC : IEntityTypeConfiguration<MedicalCenterSpecialistSlim>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSpecialistSlim> builder)
        {
            builder.ToTable("MedicalCenterSpecialists").HasKey(x => x.MedicalCenterSpecialistGuid);
            builder.Property(x => x.MedicalCenterSpecialistGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialistSlim.MedicalCenterSpecialistGuid)).IsRequired();
            builder.Property(x => x.SpecialistGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialistSlim.SpecialistGuid));
            builder.Property(x => x.MedicalCenterGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).IsRequired()
                //.HasColumnName(nameof(MedicalCenterSpecialistSlim.MedicalCenterGuid))
                ;
            builder.HasOne<MedicalCenterSlim>(s => s.MedicalCenter).WithMany(x => x.MedicalCenterSpecialists).HasForeignKey(s => s.MedicalCenterGuid);
        }
    }
}