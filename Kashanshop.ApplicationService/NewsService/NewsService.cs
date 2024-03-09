using Kashanshop.Data.sqlserver;
using Kashanshop.Domain.News;
using Kashanshop.Web.Models.news;
using Microsoft.EntityFrameworkCore;

namespace Kashanshop.ApplicationService.NewsService;

public class NewsService:INewsService
{
    private ApplicationDbContext _context;
    public NewsService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task NewNewsAsync(NewsViewModel model)
    {
        News news = new News()
        {
            Titel = model.Titel,
            CreationDate = model.CreationDate,
            UserId = model.UserId,

        };
        await _context.AddAsync(news);
    }

    public async Task<List<NewsViewModel>> GetAllNewsListAsync()
    {
        var newsList =await _context.NewsEnumerable.ToListAsync();
        List<NewsViewModel> newsViewModels = new List<NewsViewModel>();
        foreach (var n in newsList)
        {
            newsViewModels.Add(new NewsViewModel()
            {
                Titel = n.Titel,
                CreationDate = n.CreationDate,
                NewsText = n.NewsText,
                UserId = n.UserId
            });
        }
        return newsViewModels;
    }

    public async Task<List<NewsViewModel>> GetNewsListAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public async Task EditNewsAsync(NewsViewModel model)
    {
        var news = await _context.NewsEnumerable.FirstOrDefaultAsync(x => x.Id == model.Id);
        if (news != null)
        {
            news.Titel = model.Titel;
            news.UserId = model.UserId;
            news.CreationDate = model.CreationDate;
            news.NewsText = model.NewsText;
        }
    }

    public async Task DeleteNewsAsync(int newsId)
    {
        var news = await _context.NewsEnumerable.FirstOrDefaultAsync(x => x.Id == newsId);
        if (news != null)
        {
            _context.NewsEnumerable.Remove(news);
        }
    }

    public async Task NewCategoryNewsAsync(CategoryNewsViewModel categoryNews)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteCategoryNewsAsync(int categoryId, int categoryNewsId)
    {
        throw new NotImplementedException();
    }
}