

using Kashanshop.Web.Models.news;

namespace Kashanshop.ApplicationService.NewsService;

public interface INewsService
{
    Task NewNewsAsync(NewsViewModel news);
    Task<List<NewsViewModel>> GetAllNewsListAsync();
    Task<List<NewsViewModel>> GetNewsListAsync(int categoryId);
    Task EditNewsAsync(NewsViewModel news);
    Task DeleteNewsAsync(int newsId);
    Task NewCategoryNewsAsync(CategoryNewsViewModel categoryNews);
    Task DeleteCategoryNewsAsync(int categoryId ,int categoryNewsId);
}
