namespace Kashanshop.Web.Models.Feedback;

public class ProductQuestionViewModel
{
    public ProductQuestionViewModel()
    {
        Like = 0;
        Dislike = 0;
    }
    public string Titel { get; set; }
    public string Question{ get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime CreationDate { get ; set; }

}