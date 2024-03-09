

using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface IProductQuestionService
{
    Task AddProductQuestionAsync(ProductQuestionViewModel model);
    Task DeleteProductQuestionAsync(int ProductQuestionId);
    Task<ProductQuestionViewModel> GetProductQuestion(int ProductQuestionId);
    Task<List<ProductQuestionViewModel>> GetAllProductQuestion(int ProductQuestionId);
}