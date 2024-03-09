using Kashanshop.Domain.Feedback;

namespace Kashanshop.Domain.User;

public class User:BaseEntity
{

    public string Name { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string? Image { get; set; }
    public  UserStatus ActivationStatus { get; set; }
    public string? NationalCode { get; set; }
    public string SerilNum {get ; set;}
    public string PhoneNumber { get; set; }
    public List<UserRole> UserRoles { get; set; }
    public List<Message>? Messages { get; set; }
    public List<OtpCode>? OtpCodes { get; set; }
    public List<ReceiverAddress>? ReceiverAddresses { get; set; }
    public List<Product>? Products { get; set; }
    public List<Factor.Factor>? Factors { get; set; }
    public List<ProductComment>? ProductComments { get; set; }
    public List<ProductQuestion>? ProductQuestions { get; set; }
    public List<CommentReply>? CommentReplies { get; set; }
    public List<QuestionReply>? QuestionRepliess { get; set; }
    public List<ProductView>? ProductViews { get; set; }
    public List<ProductPopularity>? ProductPops { get; set; }
    public List<NewsView>? NewsViews { get; set; }
    public List<NewsPopularity>? NewsPopularities { get; set; }
    public List<News.News> NewsList { get; set; }

}