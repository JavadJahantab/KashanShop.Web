

using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface IProductViewService
{
    Task AddProductViewAsync(ProductViewViewModel model);
    Task DeleteProductViewAsync(int ProductViewId);
    Task<ProductViewViewModel> GetProductView(int ProductViewId);
    Task<List<ProductViewViewModel>> GetAllProductView(int ProductViewId);
}