namespace Kashanshop.Domain.Feedback;

public class ProductQuestion : BaseEntity
{
    public ProductQuestion()
    {
        Like = 0;
        Dislike = 0;
    }
    public string Titel { get; set; }
    public string Question{ get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public List<QuestionReply> QuestionReplies { get; set; }

}