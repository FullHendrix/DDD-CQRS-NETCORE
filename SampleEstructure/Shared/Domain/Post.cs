namespace SampleEstructure.Shared.Domain
{
    public class Post
    {
        public int IdPost { get; private set; }
        public int IdBlog { get; private set; }
        public string Title{ get; private set; }
        public Blog Blog { get; private set; }
        public Post(int IdPost, int IdBlog, string Title)
        {
            this.IdPost = IdPost;
            this.IdBlog = IdBlog;
            this.Title = Title;
        }
        public static Post Create(int IdPost, int IdBlog, string Title)
        {
            return new Post(IdPost,IdBlog,Title);
        }
    }
}