namespace Kashanshop.Domain.Feedback;

public class ProductView:BaseEntity
{
    public User.User? User { get; set; }
    public int UserId { get; set; }
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public int? IP { get; set; }
}