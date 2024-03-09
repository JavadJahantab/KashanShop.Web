
namespace Kashanshop.Web.Models.news;
public class MessageViewModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Titel { get; set; }
    public string? Value { get; set; }
    public MessageStatus Status { get; set; }
    public DateTime CreationDate { get ; set; }

}