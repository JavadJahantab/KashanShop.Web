namespace Kashanshop.Domain;

public class ProductPrice:BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    
}