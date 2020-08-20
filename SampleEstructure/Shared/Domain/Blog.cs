using System.Collections.Generic;
namespace SampleEstructure.Shared.Domain
{
    public class Blog
    {
        public int IdBlog { get; private set; }
        public string Url { get; private set; }
        public ICollection<Post> Posts { get; private set; }
        private Blog(int IdBlog, string Url)
        {
            this.IdBlog = IdBlog;
            this.Url = Url;
            this.Posts = new HashSet<Post>();
        }
        public static Blog Create(int IdBlog, string Url)
        {
            return new Blog(IdBlog, Url);
        }
        public void AddPost(int IdPost,  string Title)
        {
            this.Posts.Add(Post.Create(IdPost, this.IdBlog, Title));
        }
    }
}