using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface INewsViewService
{
    Task AddNewsViewAsync(NewsViewViewModel model);
    Task DeleteNewsViewAsync(int NewsViewId);
    Task<NewsViewViewModel> GetNewsView(int NewsViewId);
    Task<List<NewsViewViewModel>> GetAllNewsView(int NewsViewId);
}