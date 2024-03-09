
using Kashanshop.Domain.User;

namespace Kashanshop.Web.Models.news;

public class UserViewModel
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string? Password { get; set; }
    public string? Image { get; set; }
    public  UserStatus ActivationStatus { get; set; }
    public string? NationalCode { get; set; }
    public string PhoneNumber { get; set; }
}