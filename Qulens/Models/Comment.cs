namespace Qulens.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; } = string.Empty;
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile? Profile { get; set; }
    }
}