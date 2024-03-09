using Kashanshop.Domain.News;

namespace Kashanshop.Domain;

public class ProductCategory : BaseEntity
{
    public string Name { get; set; }
    public int Code { get; set; }
    public ProductCategory? LeaderCategory { get; set; }
    public int? LeaderCategoryId { get; set; }
    public List<ProductCategory>? SubCategories { get; set; }
    public List<Product> Products { get; set; }

}