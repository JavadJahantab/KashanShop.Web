namespace Kashanshop.Domain.Feedback;

public class CommentReply:BaseEntity
{
    public CommentReply()
    {
        Like = 0;
        Dislike = 0;
    }
    public string Titel { get; set; }
    public string Reply { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public ProductComment ProductComment { get; set; }
    public int ProductCommentId { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; } 
}