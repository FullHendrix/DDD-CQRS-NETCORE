using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Shared.Domain;
using SampleEstructure.Shared.Domain.ValueObject;

namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class MedicalCenterSlimC : IEntityTypeConfiguration<MedicalCenterSlim>
    {
        public void Configure(EntityTypeBuilder<MedicalCenterSlim> builder)
        {
            builder.ToTable("MedicalCenters").HasKey(x => x.MedicalCenterGuid);
            builder.Property(x => x.MedicalCenterGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).ValueGeneratedOnAdd()
            //.HasColumnName(nameof(MedicalCenterSlim.MedicalCenterGuid)).IsRequired()
            ;
            builder.Property(x => x.MedicalCenterName).HasConversion(v => v.Value, v => new StringValueObject(v)).HasColumnName(nameof(MedicalCenterSlim.MedicalCenterName));
            builder.Property(x => x.UbigeoId).HasConversion(v => v.Value, v => new IntValueObject(v)).HasColumnName(nameof(MedicalCenterSlim.UbigeoId));
            builder.Property(x => x.Address).HasConversion(v => v.Value, v => new AlphanumericValueObject(v)).HasColumnName(nameof(MedicalCenterSlim.Address));
            builder.Property(x => x.RepresentativeName).HasConversion(v => v.Value, v => new StringValueObject(v)).HasColumnName(nameof(MedicalCenterSlim.RepresentativeName));
            builder.Property(x => x.CompanyGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(MedicalCenterSlim.CompanyGuid));
        }
    }
}