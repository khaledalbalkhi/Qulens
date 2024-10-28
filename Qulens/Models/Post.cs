namespace Qulens.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? ProfileId { get; set; } 
        public virtual Profile? Profile { get; set; }
        public int? CommentId { get; set; }
        // navigation property
        public virtual List<Comment>? Comments { get; set; }
        public int? LikeId { get; set; }
        // navigation property
        public virtual List<Like>? Likes { get; set; }

    }
}