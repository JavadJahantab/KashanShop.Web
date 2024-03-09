namespace Kashanshop.Domain.Feedback;

public class ProductPopularity : BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
    public int Star { get; set; }

}