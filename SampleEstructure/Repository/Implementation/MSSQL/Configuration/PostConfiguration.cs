using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleEstructure.Shared.Domain;
namespace SampleEstructure.Repository.Implementation.MSSQL.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts").HasKey(nameof(Post.IdPost));
            builder.HasOne<Blog>(s => s.Blog).WithMany(g => g.Posts).HasForeignKey(s => s.IdBlog);
        }
    }
}
