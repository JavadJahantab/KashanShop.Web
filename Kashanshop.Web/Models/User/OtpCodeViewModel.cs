
namespace Kashanshop.Web.Models.news;
public class OtpCodeViewModel
{
    public OtpCodeViewModel()
    {
        ExpireDate=DateTime.Now.AddMinutes(5);
    }
    public int Id { get; set; }
    public string Code { get; set; }
    public DateTime ExpireDate { get; set; }
    public bool IsUsed { get; set; }
    public bool IsValid => !IsUsed && ExpireDate > DateTime.Now;
    public int UserId { get; set; }

}