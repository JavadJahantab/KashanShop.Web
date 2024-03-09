
using Kashanshop.Web.Models.Feedback;
using Kashanshop.Web.Models.Product;

namespace Kashanshop.ApplicationService;

public interface IProductCommentService
{
    Task AddProductCommentAsync(ProductCommentViewModel model);
    Task DeleteProductCommentAsync(int ProductCommentId);
    Task<ProductCommentViewModel> GetProductComment(int ProductCommentId);
    Task<List<ProductCommentViewModel>> GetAllProductComment(int ProductCommentId);
}