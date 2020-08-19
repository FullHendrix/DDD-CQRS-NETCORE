using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Companies.Domain;
using SampleEstructure.Shared.Domain.ValueObject;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company").HasKey("CompanyGuid");
            builder.Property(x => x.CompanyGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(Company.CompanyGuid));
            builder.Property(x => x.CompanyNanme).HasConversion(v => v.Value, v => new StringValueObject(v.ToString())).HasColumnName(nameof(Company.CompanyNanme));
            builder.Property(x => x.DocumentType).HasConversion(v => v.Value, v => new IntValueObject(v)).HasColumnName(nameof(Company.DocumentType));
            builder.Property(x => x.DocumentNumber).HasConversion(v => v.Value, v => new AlphanumericValueObject(v.ToString())).HasColumnName(nameof(Company.DocumentNumber));
            builder.Property(x => x.LegalRepresentativeGuid).HasConversion(v => v.Value, v => new GuidValueObject(v.ToString())).HasColumnName(nameof(Company.LegalRepresentativeGuid));
            builder.Property(x => x.Active).HasColumnName(nameof(Company.Active));
            builder.Property(x => x.CreationDate).HasColumnName(nameof(Company.CreationDate));
            builder.Property(x => x.CreationUser).HasConversion(v => v.Value, v => new Email(v)).HasColumnName(nameof(Company.CreationUser));
            builder.Property(x => x.ModificationDate).HasColumnName(nameof(Company.ModificationDate));
            builder.Property(x => x.ModificationUser).HasConversion(v => v.Value, v => new Email(v)).HasColumnName(nameof(Company.ModificationUser));

        }
    }
}