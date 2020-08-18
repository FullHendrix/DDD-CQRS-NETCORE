using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterSpecialityConfiguration : IEntityTypeConfiguration<MedicalCenterSpeciality>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSpeciality> builder)
        {
            builder.ToTable(nameof(MedicalCenterSpeciality)).HasKey(nameof(MedicalCenterSpeciality.MedicalCenterSpecialityGuid));
            builder.Property(x => x.MedicalCenterSpecialityGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpeciality.MedicalCenterSpecialityGuid));
            builder.Property(x => x.SpecialityGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpeciality.SpecialityGuid));
            builder.Property(x => x.MedicalCenterGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpeciality.MedicalCenterGuid));
            builder.Property(x => x.Active).HasColumnName(nameof(MedicalCenterSpeciality.Active));
            builder.Property(x => x.CreationDate).HasColumnName(nameof(MedicalCenterSpeciality.CreationDate));
            builder.Property(x => x.CreationUser).HasConversion(v => v.Value, v => new Email(v)).HasColumnName(nameof(MedicalCenterSpeciality.CreationUser));
            builder.Property(x => x.ModificationDate).HasColumnName(nameof(MedicalCenterSpeciality.ModificationDate));
            builder.Property(x => x.ModificationUser).HasConversion(v => v.Value, v => new Email(v)).HasColumnName(nameof(MedicalCenterSpeciality.ModificationUser));
        }
    }
}
