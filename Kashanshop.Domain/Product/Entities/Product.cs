using Kashanshop.Domain.Factor;
using Kashanshop.Domain.Feedback;
using Kashanshop.Domain.User;

namespace Kashanshop.Domain;

public class Product:BaseEntity
{
    public ProductCategory Category { get; set; }
    public int CategoryId { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
    public string ProductName { get; set; }
    public int? ProductCode { get; set; }
    public string? Description { get; set; }
    public ProductStatus ProductStatus { get; set; }
    public List<ProductField> ProductFields { get; set; }
    public List<ProductInventory> ProductInventories { get; set; }
    public List<ProductPrice> ProductPrices { get; set; }
    public List<ProductQuestion>? ProductQuestions { get; set; }
    public List<ProductComment>? ProductComments { get; set; }
    public List<ProductView>? ProductViews { get; set; }
    public List<ProductPopularity>? ProductPopularities { get; set; }
    public List<FactorItem> FactorItems { get; set; }

}