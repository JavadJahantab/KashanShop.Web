namespace Kashanshop.Domain.Factor;

public class FactorItem:BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public Factor Factor { get; set; }
    public int FactorId { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}