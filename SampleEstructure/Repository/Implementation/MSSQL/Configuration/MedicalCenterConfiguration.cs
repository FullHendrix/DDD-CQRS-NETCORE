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
            builder.ToTable("MedicalCenter");

            builder.HasKey(x => x.MedicalCenterGuid);

            builder.Property(x => x.MedicalCenterGuid)
            .HasConversion(v => v.Value, v => new GuidValueObject(v.ToString()))
            .HasColumnName("MedicalCenterGuid");

            builder.Property(x => x.MedicalCenterName)
            .HasConversion(v => v.Value, v => new StringValueObject(v))
            .HasColumnName("MedicalCenterName");

            builder.Property(x => x.UbigeoId)
            .HasConversion(v => v.Value, v => new IntValueObject(v))
            .HasColumnName("UbigeoId");

            builder.Property(x => x.Address)
            .HasConversion(v => v.Value, v => new AlphanumericValueObject(v))
            .HasColumnName("Address");

            builder.Property(x => x.RepresentativeName)
            .HasConversion(v => v.Value, v => new StringValueObject(v))
            .HasColumnName("RepresentativeName");

            builder.Property(x => x.CompanyGuid)
            .HasConversion(v => v.Value, v => new GuidValueObject(v.ToString()))
            .HasColumnName("CompanyGuid");

            builder.Property(x => x.Active).HasColumnName("Active");

            

            //builder.Metadata.FindNavigation(nameof(MedicalCenter.medicalCenterSpecialists)).SetPropertyAccessMode(PropertyAccessMode.Field);


            //builder.Property(x => x.CreationDate).HasColumnName("CreationDate");

            //builder.Property(x => x.CreationUser)
            //.HasConversion(v => v.Value, v => new Email(v))
            //.HasColumnName("CreationUser");

            //builder.Property(x => x.ModificationDate).HasColumnName("ModificationDate");

            //builder.Property(x => x.ModificationUser)
            //.HasConversion(v => v.Value, v => new Email(v))
            //.HasColumnName("ModificationUser");
        }
    }
}