namespace Kashanshop.Web.Models.news;



public class NewsViewModel
{
    public int? Id { get; set; }
    public string Titel { get; set; }
    public string NewsText { get; set; }
    public int UserId { get; set; }
    public DateTime CreationDate { get ; set; }

}