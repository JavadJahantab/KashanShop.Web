using Kashanshop.Web.Models.Feedback;

namespace Kashanshop.ApplicationService;

public interface INewsPopularityService
{
    Task AddNewsPopularityAsync(NewsPopularityViewModel model);
    Task DeleteNewsPopularityAsync(int NewsPopularityId);
    Task<NewsPopularityViewModel> GetCNewsPopularity(int NewsPopularityId);
    Task<List<NewsPopularityViewModel>> GetAllNewsPopularity(int NewsPopularityId);
}