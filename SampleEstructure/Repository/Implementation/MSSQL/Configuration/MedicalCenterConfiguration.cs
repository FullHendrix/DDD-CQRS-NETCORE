using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.MedicalCenters.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterConfiguration : IEntityTypeConfiguration<MedicalCenter>
    {
        public void Configure(EntityTypeBuilder<MedicalCenter> builder)
        {
            builder.ToTable("MedicalCenters_").HasKey(x => x.MedicalCenterGuid);
            builder.Property(x => x.MedicalCenterGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenter.MedicalCenterGuid));
            builder.Property(x => x.MedicalCenterName).HasConversion(v => v.Value, v => new StringValueObject(v)).HasColumnName(nameof(MedicalCenter.MedicalCenterName));
            builder.Property(x => x.UbigeoId).HasConversion(v => v.Value, v => new IntValueObject(v)).HasColumnName(nameof(MedicalCenter.UbigeoId));
            builder.Property(x => x.Address).HasConversion(v => v.Value, v => new AlphanumericValueObject(v)).HasColumnName(nameof(MedicalCenter.Address));
            builder.Property(x => x.RepresentativeName).HasConversion(v => v.Value, v => new StringValueObject(v)).HasColumnName(nameof(MedicalCenter.RepresentativeName));
            builder.Property(x => x.CompanyGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenter.CompanyGuid));
        }
    }
}