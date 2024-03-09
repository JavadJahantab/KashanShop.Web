namespace Kashanshop.Domain;

public class ProductInventory:BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }
    public int Inventory { get; set; } 
}