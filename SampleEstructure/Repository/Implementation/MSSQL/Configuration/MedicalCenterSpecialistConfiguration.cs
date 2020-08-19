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
            builder.ToTable(nameof(MedicalCenterSpecialist)).HasKey(nameof(MedicalCenterSpecialist.MedicalCenterSpecialistGuid));
            builder.Property(x => x.MedicalCenterSpecialistGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialist.MedicalCenterSpecialistGuid));
            builder.Property(x => x.SpecialistGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialist.SpecialistGuid));
            builder.Property(x => x.MedicalCenterGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSpecialist.MedicalCenterGuid));
            builder.Property(x => x.Active).HasColumnName(nameof(MedicalCenterSpecialist.Active));
            builder.HasOne(x => x.MedicalCenterNavigation).WithMany(p => p.medicalCenterSpecialists).HasForeignKey(d => d.MedicalCenterGuid);
            //builder.HasOne( x => x.MedicalCenterGuid).WithMany(A  => A.)
            //builder.Property(x => x.CreationDate).HasColumnName(nameof(MedicalCenterSpecialist.CreationDate));
            //builder.Property(x => x.CreationUser).HasConversion(v => v.Value, v => new Email(v)).HasColumnName(nameof(MedicalCenterSpecialist.CreationUser));
            //builder.Property(x => x.ModificationDate).HasColumnName(nameof(MedicalCenterSpecialist.ModificationDate));
            //builder.Property(x => x.ModificationUser).HasConversion(v => v.Value, v => new Email(v)).HasColumnName(nameof(MedicalCenterSpecialist.ModificationUser));
        }
    }
}