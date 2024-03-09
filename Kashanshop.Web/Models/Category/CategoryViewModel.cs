

using Kashanshop.Domain.News;

namespace Kashanshop.Domain;

public class CategoryViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Code { get; set; }
    public int? LeaderCategoryId { get; set; }
}