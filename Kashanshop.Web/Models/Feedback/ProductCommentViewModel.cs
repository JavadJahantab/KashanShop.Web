namespace Kashanshop.Web.Models.Feedback;

public class ProductCommentViewModel
{
    public ProductCommentViewModel()
    {
        Like = 0;
        Dislike = 0;
    }
    public string Titel { get; set; }
    public string Comment { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public DateTime CreationDate { get ; set; }


}