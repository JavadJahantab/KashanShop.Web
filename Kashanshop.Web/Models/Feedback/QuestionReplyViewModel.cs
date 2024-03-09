namespace Kashanshop.Web.Models.Feedback;

public class QuestionReplyViewModel
{
    public QuestionReplyViewModel()
    {
        Like = 0;
        Dislike = 0;
    }
    public string Titel { get; set; }
    public string Reply { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public int ProductQuestionId { get; set; }
    public int UserId { get; set; }
    public DateTime CreationDate { get ; set; }

}