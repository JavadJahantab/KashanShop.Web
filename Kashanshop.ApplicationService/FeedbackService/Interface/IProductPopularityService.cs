
using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface IProductPopularityService
{
    Task AddProductPopularityAsync(ProductPopularityViewModel model);
    Task DeleteProductPopularityAsync(int ProductPopularityId);
    Task<ProductPopularityViewModel> GetProductPopularity(int ProductPopularityId);
    Task<List<ProductPopularityViewModel>> GetAllProductPopularity(int ProductPopularityId);
}