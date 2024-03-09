using Kashanshop.Domain.Feedback;

namespace Kashanshop.Domain.News;

public class News:BaseEntity
{
    public string Titel { get; set; }
    public string NewsText { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
    public List<NewsCategory> CategoryNewsList { get; set; }
    public List<NewsPopularity>? NewsPops { get; set; }
    public List<NewsView> NewsViews { get; set; }
}