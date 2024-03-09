namespace Kashanshop.Domain.Feedback;

public class NewsPopularity:BaseEntity
{
    public News.News News { get; set; }
    public int NewsId { get; set; }
    public User.User User { get; set; }
    public int UserId { get; set; }
    public int Star { get; set; }
}