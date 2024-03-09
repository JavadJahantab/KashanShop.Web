namespace Kashanshop.Domain.Feedback;

public class NewsView:BaseEntity
{
    public User.User? User { get; set; }
    public News.News News { get; set; }
    public int NewsId { get; set; }
    public int UserId { get; set; }
    public int? IP { get; set; }   
}