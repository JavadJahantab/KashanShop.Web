namespace Kashanshop.Web.Models.Feedback;

public class ProductViewViewModel
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int? IP { get; set; }
    public DateTime CreationDate { get ; set; }

}