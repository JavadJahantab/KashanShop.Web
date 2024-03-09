using Kashanshop.Domain;
using Kashanshop.Domain.Factor;
using Kashanshop.Domain.Feedback;
using Kashanshop.Domain.User;

namespace Kashanshop.Web.Models.Product;

public class ProductViewModel
{
    public int CategoryId { get; set; }
    public int UserId { get; set; }
    public string ProductName { get; set; }
    public int? ProductCode { get; set; }
    public string? Description { get; set; }
    public ProductStatus ProductStatus { get; set; }

}