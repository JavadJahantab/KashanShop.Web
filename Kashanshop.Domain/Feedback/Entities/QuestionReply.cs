namespace Kashanshop.Domain.Feedback;

public class QuestionReply:BaseEntity
{
    public QuestionReply()
    {
        Like = 0;
        Dislike = 0;
    }
    public string Titel { get; set; }
    public string Reply { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public ProductQuestion ProductQuestion { get; set; }
    public int ProductQuestionId { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
}