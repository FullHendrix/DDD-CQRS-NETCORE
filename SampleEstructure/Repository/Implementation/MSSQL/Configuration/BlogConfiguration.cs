using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Shared.Domain;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs").HasKey(nameof(Blog.IdBlog));
        }
    }
}
