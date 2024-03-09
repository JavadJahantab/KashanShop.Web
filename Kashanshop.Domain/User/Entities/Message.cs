using Kashanshop.Domain;
using Kashanshop.Domain.User;

public class Message : BaseEntity
{
    public User User { get; set; }
    public int UserId { get; set; }
    public string Titel { get; set; }
    public string? Text { get; set; }
    public MessageStatus Status { get; set; }
}