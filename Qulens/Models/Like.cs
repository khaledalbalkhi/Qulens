namespace Qulens.Models
{
    public class Like
    {
        public int LikeId { get; set; }
        public bool IsLiked { get; set; }
        public int PostId { get; set; }
        // navigation property
        public virtual Post? Post { get; set; }
        public int ProfileId { get; set; }
        // navigation property
        public virtual Profile? Profile { get; set; }
    }
}