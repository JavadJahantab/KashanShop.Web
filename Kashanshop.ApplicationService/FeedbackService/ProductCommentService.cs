using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService.FeedbackService;

public class ProductCommentService:IProductCommentService
{
    public async Task AddProductCommentAsync(ProductCommentViewModel model)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteProductCommentAsync(int ProductCommentId)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductCommentViewModel> GetProductComment(int ProductCommentId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ProductCommentViewModel>> GetAllProductComment(int ProductCommentId)
    {
        throw new NotImplementedException();
    }
}