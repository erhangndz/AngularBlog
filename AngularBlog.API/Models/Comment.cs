namespace AngularBlog.API.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public string  Name { get; set; }
        public string  CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
